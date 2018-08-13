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
    public partial class IzlaziReport : Form
    {
        private WebAPIHelper izlaziService = new WebAPIHelper("http://localhost:60271/", "api/Izlazis");
        private int izlazId = 0;

        public IzlaziReport(int id)
        {
            izlazId = id;
            InitializeComponent();
        }

        private void IzlaziReport_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = izlaziService.getActionResponse("GetIzlaziStavkeByIzlazID", izlazId.ToString());

            if (response.IsSuccessStatusCode)
            {

                bindingSource.DataSource =
                   response.Content.ReadAsAsync<List<esp_IzlaziStavkeByIzlazID_Result>>().Result;

                ReportDataSource rds = new ReportDataSource("Entity",
                    bindingSource);
                reportViewer.LocalReport.DataSources.Add(rds);
                this.reportViewer.RefreshReport();
            }

            else
                MessageBox.Show("Not found!");
         
            this.reportViewer.RefreshReport();
         
        }
    }
}
