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

namespace eProdaja_UI.Buyes
{
    public partial class KupciPrijedlozi : MetroFramework.Forms.MetroForm
    {
        private WebAPIHelper prijedlogService = new WebAPIHelper("http://localhost:60271/", "api/PrijedlogKupca");
         
        public KupciPrijedlozi()
        {
            InitializeComponent();
        }


        private void KupciPrijedlozi_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            HttpResponseMessage response = prijedlogService.getResponse("SelectAll");
            if (response.IsSuccessStatusCode)
            {
                dgvKupci.AutoGenerateColumns = false;
                dgvKupci.DataSource = response.Content.ReadAsAsync<List<esp_PrijedlogKupca_SelectAll_Result>>().Result;

            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
            }
        }

        private void dgvKupci_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtPrijedlog.Text = dgvKupci.SelectedRows[0].Cells["Naziv"].Value.ToString() + " : " +
                            dgvKupci.SelectedRows[0].Cells["Sadrzaj"].Value.ToString();

        }
    }
}
