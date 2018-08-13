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

namespace eProdaja_UI.Buyes
{
    public partial class KupciForm :MetroFramework.Forms.MetroForm
    {
        private WebAPIHelper kupciService = new WebAPIHelper("http://localhost:60271/", "api/Kupci");

        public KupciForm()
        {
            InitializeComponent();
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            BindTraziKupac();
        }

        private void BindTraziKupac()
        {
            HttpResponseMessage response = kupciService.getActionResponse("GetKupacSearch", txtKupac.Text);
            if (response.IsSuccessStatusCode)
            {
                dgvKupci.AutoGenerateColumns = false;
                dgvKupci.DataSource = response.Content.ReadAsAsync<List<Kupci>>().Result;

            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
            }
        }

        private void KupciForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            HttpResponseMessage response = kupciService.getResponse();
            if (response.IsSuccessStatusCode)
            {
                dgvKupci.AutoGenerateColumns = false;
                dgvKupci.DataSource = response.Content.ReadAsAsync<List<Kupci>>().Result;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
            }
        }

        private void btnRefrehs_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnOcjene_Click(object sender, EventArgs e)
        {
            KupacOcjene ocjene = new KupacOcjene();
            ocjene.Show();
        }

        private void btnPrijedlozi_Click(object sender, EventArgs e)
        {
            KupciPrijedlozi prijedlzi = new KupciPrijedlozi();
            prijedlzi.Show();
        }

     
        private void dgvKupci_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int kupacID = Convert.ToInt32(dgvKupci.SelectedRows[0].Cells[0].Value.ToString());
            KupciNarudzbe narudzbe = new KupciNarudzbe(kupacID);
            narudzbe.Show();
        }
    }
}
