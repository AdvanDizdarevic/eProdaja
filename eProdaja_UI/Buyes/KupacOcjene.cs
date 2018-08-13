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
    public partial class KupacOcjene : MetroFramework.Forms.MetroForm
    {

        private WebAPIHelper ocjeneService = new WebAPIHelper("http://localhost:60271/", "api/Ocjene");

        public KupacOcjene()
        {
            InitializeComponent();
        }

        private void KupacOcjene_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {

            HttpResponseMessage response = ocjeneService.getResponse("SelectAll");
            if (response.IsSuccessStatusCode)
            {
               
                dgvOcjene.DataSource = response.Content.ReadAsAsync<List<esp_Ocjene_SelectAll_Result>>().Result;

            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
            }
        }
    }
}
