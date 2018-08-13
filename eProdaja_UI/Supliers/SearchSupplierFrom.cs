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

namespace eProdaja_UI.Supliers
{
    public partial class SearchSupplierFrom : MetroFramework.Forms.MetroForm
    {
        private WebAPIHelper dobavljacService = new WebAPIHelper("http://localhost:60271/", "api/Dobavljaci");

        public SearchSupplierFrom()
        {
            InitializeComponent();
        }

        private void SearchSupplierFrom_Load(object sender, EventArgs e)
        {
            BindDobavljaci();
        }

        private void BindDobavljaci()
        {
            HttpResponseMessage response = dobavljacService.getActionResponse("GetAktivni");
            if (response.IsSuccessStatusCode)
            {
                gridDobavljaci.AutoGenerateColumns = false;
                gridDobavljaci.DataMember = response.Content.ReadAsAsync<List<Dobavljaci>>().Result.ToString();
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"), Global.GetMessage("warning"));
            }
        }

        private void buttonTrazi_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = dobavljacService.getActionResponse("GetSearch",
                textPretragaDobavljaca.Text.Trim());
            if (response.IsSuccessStatusCode)
            {
                gridDobavljaci.AutoGenerateColumns = false;
                gridDobavljaci.DataSource = response.Content.ReadAsAsync<List<Dobavljaci>>().Result;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"), Global.GetMessage("warning"));
            }
        }

       

        private void gridDobavljaci_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (gridDobavljaci.Rows.Count == 0)
            {
                MessageBox.Show(Global.GetMessage("item_sel_err"), Global.GetMessage("warning"));
            }
            else
            {
                HttpResponseMessage response =
               dobavljacService.getActionResponse(gridDobavljaci.SelectedRows[0].Cells[0].Value.ToString());
                if (response.IsSuccessStatusCode)
                {
                    Global.odabraniDobavljac = response.Content.ReadAsAsync<Dobavljaci>().Result;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(Global.GetMessage("api_error"), Global.GetMessage("warning"));
                }
            }
        }
    }
}
