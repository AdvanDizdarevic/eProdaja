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
using eProdaja_UI;
using eProdaja_UI.Util;


namespace eProdaja_UI.AkcijskiProizvodi
{
    public partial class ProductActionForm : MetroFramework.Forms.MetroForm
    {
        private WebAPIHelper akcijskiProizvodiService = new WebAPIHelper("http://localhost:60271/", "api/AkcijskiProizvodi");
        private List<esp_AkcijskiProizvodi_SelectTrenutnoAktivni_Result> akcijskiProizvodi { get; set; } 

        public ProductActionForm()
        {
            InitializeComponent();
        }

    

        private void dodajNaAkcijuBtn_Click(object sender, EventArgs e)
        {
            AddProductOnAction dodajNaAkcijuProizvodForm = new AddProductOnAction();
            dodajNaAkcijuProizvodForm.Show();
        }

        private void ProductActionForm_Load(object sender, EventArgs e)
        {
            BindAkcijskiProizvodi();
        }

        private void BindAkcijskiProizvodi()
        {
            HttpResponseMessage response = akcijskiProizvodiService.getActionResponse("GetTrenutnoAktivni");
            if (response.IsSuccessStatusCode)
            {
                akcijskiProizvodi =
                    response.Content.ReadAsAsync<List<esp_AkcijskiProizvodi_SelectTrenutnoAktivni_Result>>().Result;
                metroGrid1.DataSource = akcijskiProizvodi;
            }
            else
                MessageBox.Show(Global.GetMessage("api_error"));
        }

        private void ukloniProizvodBtn_Click(object sender, EventArgs e)
        {
            if (metroGrid1.Rows.Count == 0)
                MessageBox.Show(Global.GetMessage("item_sel_err"));
            else
            {
                int proizvodID = Convert.ToInt32(metroGrid1.SelectedRows[0].Cells["AkcijskiProizvodID"].Value.ToString());


                if (proizvodID > 0)
                {
                    DialogResult message = MessageBox.Show("Jeste li sigurni da želite izbrisati označeni proizvod?",
                        Global.GetMessage("confirmation"), MessageBoxButtons.YesNo);
                    if (message == DialogResult.Yes)
                    {
                        HttpResponseMessage response = akcijskiProizvodiService.DeleteResponse(proizvodID);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show(Global.GetMessage("item_del_succ"));
                            BindAkcijskiProizvodi();
                        }
                        else
                        {
                            MessageBox.Show(Global.GetMessage("api_error"));

                        }
                    }

                }
                else
                    MessageBox.Show(Global.GetMessage("item_sel_err"));
            }
        }

        private void urediProizvodBtn_Click(object sender, EventArgs e)
        {
            if (metroGrid1.Rows.Count == 0)
                MessageBox.Show(Global.GetMessage("item_sel_err"));
            else
            {
                int proizvodID = Convert.ToInt32(metroGrid1.SelectedRows[0].Cells["AkcijskiProizvodID"].Value.ToString());
                string nazivProizvoda = metroGrid1.SelectedRows[0].Cells["Naziv"].Value.ToString();
                string sifraProizvoda = metroGrid1.SelectedRows[0].Cells["Sifra"].Value.ToString();
                if (proizvodID > 0)
                {
                    EditProductOnAction urediProizvodNaAkcijiForm = new EditProductOnAction(proizvodID, nazivProizvoda, sifraProizvoda);
                    urediProizvodNaAkcijiForm.Show();
                    BindAkcijskiProizvodi();
                }
                else
                    MessageBox.Show(Global.GetMessage("item_sel_err"));
            }
        }

        private void osvjeziListuBtn_Click(object sender, EventArgs e)
        {
            BindAkcijskiProizvodi();
        }
    }
}
