using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eProdaja_API.Models;
using eProdaja_PCL.Util;
using Microsoft.Reporting.WinForms;

namespace eProdaja_UI.Izvjestaji
{
    public partial class UlaziReport : Form
    {
        private WebAPIHelper ulaziService = new WebAPIHelper("http://localhost:60271/", "api/Ulazi");
        private int ulazId = 0;


        public UlaziReport(int id)
        {
            InitializeComponent();
            ulazId = id;
        }

        private void UlaziReport_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = ulaziService.getActionResponse("GetUlaziStavkeByUlazID", ulazId.ToString());

            if (response.IsSuccessStatusCode)
            {

                esp_NarudzbaStavke_SelectByNarudzbaID_ResultBindingSource.DataSource =
                   response.Content.ReadAsAsync<List<esp_UlaziStavke_SelectByUlazID_Result>>().Result;

                ReportDataSource rds = new ReportDataSource("dataset",
                    esp_NarudzbaStavke_SelectByNarudzbaID_ResultBindingSource);
                reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();
            }

            else
                MessageBox.Show("Not found!");

            this.reportViewer1.RefreshReport();
        }
    }
    }
