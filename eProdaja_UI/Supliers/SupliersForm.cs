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


namespace eProdaja_UI.Supliers
{
    public partial class SupliersForm : MetroFramework.Forms.MetroForm
    {
        private WebAPIHelper dobavljaciService = new WebAPIHelper("http://localhost:60271/", "api/Dobavljaci");
        public SupliersForm()
        {
            InitializeComponent();
        }

        private void SupliersForm_Load(object sender, EventArgs e)
        {
            BindGridDobavljaciAktivni();
        }

        private void BindGridDobavljaciAktivni()
        {
            HttpResponseMessage response = dobavljaciService.getActionResponse("GetAktivni");
            if (response.IsSuccessStatusCode)
            {
                dobavljacidgw.AutoGenerateColumns = false;
                dobavljacidgw.DataSource = response.Content.ReadAsAsync<List<Dobavljaci>>().Result;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"), Global.GetMessage("warning"));
            }
        }

        private void prikaziAktivneProizvodebtn_Click(object sender, EventArgs e)
        {
            BindGridDobavljaciAktivni();
        }

        private void prikaziNeAktivneProizvodebtn_Click(object sender, EventArgs e)
        {
            BindGridDobavljaciNeAktivni();
        }

        private void BindGridDobavljaciNeAktivni()
        {
            HttpResponseMessage response = dobavljaciService.getActionResponse("GetNeAktivni");
            if (response.IsSuccessStatusCode)
            {
                dobavljacidgw.AutoGenerateColumns = false;
                dobavljacidgw.DataSource = response.Content.ReadAsAsync<List<Dobavljaci>>().Result;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"), Global.GetMessage("warning"));
            }
        }

        private void prikaziSveProizvodebtn_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = dobavljaciService.getResponse();
            if (response.IsSuccessStatusCode)
            {
                dobavljacidgw.AutoGenerateColumns = false;
                dobavljacidgw.DataSource = response.Content.ReadAsAsync<List<Dobavljaci>>().Result;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"), Global.GetMessage("warning"));
            }
        }

      

        private void dodajProizvodbtn_Click(object sender, EventArgs e)
        {
            AddSupplierForm dodajDobavljacaForm = new AddSupplierForm();
            dodajDobavljacaForm.Show();
        }

  

        private void pretragabtn_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = dobavljaciService.getActionResponse("GetSearch",
                pretragaDobavljactxt.Text.Trim());
            if (response.IsSuccessStatusCode)
            {
                dobavljacidgw.AutoGenerateColumns = false;
                dobavljacidgw.DataSource = response.Content.ReadAsAsync<List<Dobavljaci>>().Result;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
            }
        }

        private void izbrisiPorizvodbtn_Click(object sender, EventArgs e)
        {
            if (dobavljacidgw.Rows.Count == 0)
                MessageBox.Show(Global.GetMessage("item_sel_err"));
            else
            {
                int dobavljacID = Convert.ToInt32(dobavljacidgw.SelectedRows[0].Cells[0].Value.ToString());
                if (dobavljacID > 0)
                {
                    HttpResponseMessage response2 = dobavljaciService.getActionResponse("GetDobavljacStatus",
                        dobavljacID.ToString());
                    bool status = response2.Content.ReadAsAsync<bool>().Result;
                    if (!status)
                    {
                        MessageBox.Show("Dobavljac vec izbrisan!!");
                    }
                    else
                    {

                        HttpResponseMessage response = dobavljaciService.DeleteResponse(dobavljacID);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show(Global.GetMessage("item_del_succ"));
                            BindGridDobavljaciAktivni();
                        }
                        else
                            MessageBox.Show(Global.GetMessage("api_error"));
                    }
                }
                else
                    MessageBox.Show(Global.GetMessage("item_sel_err"));
            }
        }

        private void urediProizvodbtn_Click(object sender, EventArgs e)
        {
            if (dobavljacidgw.Rows.Count == 0)
                MessageBox.Show(Global.GetMessage("item_sel_err"));
            else
            {
                int supplierID = Convert.ToInt32(dobavljacidgw.SelectedRows[0].Cells[0].Value.ToString());

                EditSupplier urediDobavljaca = new EditSupplier(supplierID);
                urediDobavljaca.Show();
            }
        }

        private void dobavljacidgw_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int dobavljacID = Convert.ToInt32(dobavljacidgw.SelectedRows[0].Cells[0].Value.ToString());
            if (dobavljacID > 0)
            {
                HttpResponseMessage response = dobavljaciService.getActionResponse(dobavljacID.ToString());
                if (response.IsSuccessStatusCode)
                {
                    Dobavljaci dobavljac = response.Content.ReadAsAsync<Dobavljaci>().Result;
                    napomenatxt.Text = dobavljac.KontaktOsoba + " : " + dobavljac.Napomena;
                }
                else
                    napomenatxt.Text = Global.GetMessage("api_error");
            }
        }
    }
}
