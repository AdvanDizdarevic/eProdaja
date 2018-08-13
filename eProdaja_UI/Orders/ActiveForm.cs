using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http;
using eProdaja_API.Models;

using eProdaja_UI.Util;

namespace eProdaja_UI.Orders
{
    public partial class ActiveForm : MetroFramework.Forms.MetroForm
    {
        WebAPIHelper serviceNarudzbe = new WebAPIHelper("http://localhost:60271/", "api/Narudzbe");
        private List<esp_Narudzbe_SelectAktivne_Result> narudzbe { get; set; }
        public ActiveForm()
        {
            InitializeComponent();
        }

        private void ActiveOrders_Load(object sender, EventArgs e)
        {
            BindGrid();

        }

        private void BindGrid()
        {
            HttpResponseMessage response = serviceNarudzbe.getActionResponse("GetAktivneNarudzbe");

            if (response.IsSuccessStatusCode)
            {
                narudzbe = response.Content.ReadAsAsync<List<esp_Narudzbe_SelectAktivne_Result>>().Result;
                narudzbeGrid.DataSource = narudzbe;
                narudzbeGrid.Columns[0].Visible = false;
                narudzbeGrid.Columns[2].Visible = false;
            }
        }

      

        private void refresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void narudzbeGrid_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

            DetailsForm detailsForm = new DetailsForm(narudzbe[e.RowIndex]);
            detailsForm.Show();
            this.Close();
        }
    }
}
