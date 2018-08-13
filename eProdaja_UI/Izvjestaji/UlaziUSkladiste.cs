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

namespace eProdaja_UI.Izvjestaji
{
    public partial class UlaziUSkladiste : MetroFramework.Forms.MetroForm
    {

        WebAPIHelper ulaziService = new WebAPIHelper("http://localhost:60271/", "api/Ulazi");
        public UlaziUSkladiste()
        {
            InitializeComponent();
        }

        private void UlaziUSkladiste_Load(object sender, EventArgs e)
        {
            BindUlaz();
        }

        private void BindUlaz()
        {
            HttpResponseMessage response = ulaziService.getResponse();
            if (response.IsSuccessStatusCode)
            {
                metroGrid1.AutoGenerateColumns = false;
                
                metroGrid1.DataSource = response.Content.ReadAsAsync<List<Ulazi>>().Result;
            }
        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ulazId = Convert.ToInt32(metroGrid1.SelectedRows[0].Cells[0].Value);
            UlaziReport reportForm = new UlaziReport(ulazId);
            reportForm.Show();
        }
    }
}
