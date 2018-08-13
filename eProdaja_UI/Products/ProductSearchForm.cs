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
using eProdaja_UI.Util;
using MetroFramework.Forms;

namespace eProdaja_UI.Products
{
    public partial class ProductSearchForm : MetroFramework.Forms.MetroForm
    {
        
        private WebAPIHelper proizvodiService = new WebAPIHelper("http://localhost:60271/", "api/Proizvodi");
        public string sifraProizvod;

        public ProductSearchForm()
        {
            InitializeComponent();
        }

        private void ProductSearchForm_Load(object sender, EventArgs e)
        {
            BindProizvodList();
        }

        private void BindProizvodList()
        {
            HttpResponseMessage response = proizvodiService.getResponse();
            if (response.IsSuccessStatusCode)
            {
                gridProizvodi.DataSource = response.Content.ReadAsAsync<List<esp_Proizvodi_SelectAll_Result>>().Result;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
            }
        }

        private void btn_Trazi_Click(object sender, EventArgs e)
        {

            HttpResponseMessage response = proizvodiService.getActionResponse("GetProizvodBySifra",
                txtSifra.Text.Trim());
            if (response.IsSuccessStatusCode)
            {
                List<esp_Proizvodi_SelectBySifra_Result> proizvodi =
                    response.Content.ReadAsAsync<List<esp_Proizvodi_SelectBySifra_Result>>().Result;
                gridProizvodi.DataSource = proizvodi;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
            }
        }

  

        private void gridProizvodi_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (gridProizvodi.Rows.Count == 0)
                MessageBox.Show(Global.GetMessage("item_select_err"), Global.GetMessage("warning"));
            else
            {
                sifraProizvod = gridProizvodi.SelectedRows[0].Cells["Sifra"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
