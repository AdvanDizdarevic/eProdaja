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
    public partial class KupciNarudzbe :MetroFramework.Forms.MetroForm
    {

        private WebAPIHelper kupciService = new WebAPIHelper("http://localhost:60271/", "api/Kupci");
        private WebAPIHelper narudzbeService = new WebAPIHelper("http://localhost:60271/", "api/Narudzbe");

        private int kupacID;
        private Kupci kupac;

        public KupciNarudzbe(int id)
        {
            InitializeComponent();
            kupacID = id;
        }

        private void KupciNarudzbe_Load(object sender, EventArgs e)
        {
            BindGrid();
            GetKupac();
            lblKupac.Text = kupac.Ime + " " + kupac.Prezime;
            lblKupac.Visible = true;
        }

        private void GetKupac()
        {
            HttpResponseMessage response = kupciService.getActionResponse(kupacID.ToString());
            if (response.IsSuccessStatusCode)
            {
                kupac = response.Content.ReadAsAsync<Kupci>().Result;
            }
        }

        private void BindGrid()
        {
            HttpResponseMessage response = narudzbeService.getActionResponse("GetByKupac",kupacID.ToString());
            if (response.IsSuccessStatusCode)
            {
                dgvNarudzbe.AutoGenerateColumns = false;
                dgvNarudzbe.DataSource = response.Content.ReadAsAsync<List<esp_Narudzbe_SelectByKupac_Result>>().Result;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
            }
        }

   

        private void dgvNarudzbe_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int narudzbaID = Convert.ToInt32(dgvNarudzbe.SelectedRows[0].Cells[0].Value.ToString());
            KupacNarudzbeDetalji detalji = new KupacNarudzbeDetalji(narudzbaID);
            detalji.Show();
        }

    }
    
}
