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
    public partial class IzlaziIzSkladista : MetroFramework.Forms.MetroForm
    {

        private WebAPIHelper izlaziService = new WebAPIHelper("http://localhost:60271/", "api/Izlazis");
        public IzlaziIzSkladista()
        {
            InitializeComponent();
        }

        private void IzlaziIzSkladista_Load(object sender, EventArgs e)
        {
            BindIzlazi();
        }

        private void BindIzlazi()
        {
            HttpResponseMessage response = izlaziService.getResponse();
            if (response.IsSuccessStatusCode)
            {
                metroGrid1.AutoGenerateColumns = false;
                metroGrid1.DataSource = response.Content.ReadAsAsync<List<Izlazi>>().Result;

            }
            else
            {
                MessageBox.Show("Prazna lista");
            }
        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int izlazId = Convert.ToInt32(metroGrid1.SelectedRows[0].Cells[0].Value);
            IzlaziReport reportForm = new IzlaziReport(izlazId);
            reportForm.Show();
        }
    }
}
