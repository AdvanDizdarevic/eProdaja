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
    public partial class KupacNarudzbeDetalji : MetroFramework.Forms.MetroForm
    {

        private WebAPIHelper narudzbeService = new WebAPIHelper("http://localhost:60271/", "api/NarudzbaStavke");
        private int narudzbaID;
     

        public KupacNarudzbeDetalji(int id)
        {
            InitializeComponent();
            narudzbaID = id;
        }

        private void KupacNarudzbeDetalji_Load(object sender, EventArgs e)
        {
            BindGrid();
           
        }

        private void BindGrid()
        {

            HttpResponseMessage response = narudzbeService.getActionResponse("GetByNarudzba", narudzbaID.ToString());
            if (response.IsSuccessStatusCode)
            {
               
                dgvDetalji.DataSource = response.Content.ReadAsAsync<List<esp_NarudzbaStavke_SelectByNarudzbaID_Result>>().Result;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
            }
        }
    }
}
