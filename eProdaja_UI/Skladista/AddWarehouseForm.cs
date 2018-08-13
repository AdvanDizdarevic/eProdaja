using eProdaja_UI.Util;
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


namespace eProdaja_UI.Warehouse
{
    public partial class AddWarehouseForm : MetroFramework.Forms.MetroForm
    {
        private WebAPIHelper skladisteService = new WebAPIHelper("http://localhost:60271/", "api/Skladista");

        public AddWarehouseForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void dodajSkladistebtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Skladista skladiste = new Skladista();
                skladiste.Naziv = nazivSkladistatxt.Text;
                skladiste.Adresa = adresaSkladistatxt.Text;
                skladiste.Opis = opisSkladistatxt.Text;
                skladiste.Status = statusSkladistachb.Checked;

                HttpResponseMessage response = skladisteService.postResponse(skladiste);

                if (response.IsSuccessStatusCode)
                {
                    DialogResult dialogResult = MessageBox.Show("Uspješno ste pohranili skladište, Da li želite dodati novo?",
                        Global.GetMessage("info"), MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                        ClearInputText();
                    else
                        this.Close();
                }
                else
                {
                    MessageBox.Show(Global.GetMessage("api_error"), Global.GetMessage("warning"));
                }
            }
        }

        private void ClearInputText()
        {
            nazivSkladistatxt.Text = adresaSkladistatxt.Text = opisSkladistatxt.Text = "";
            statusSkladistachb.Checked = false;
        }
        #region Validation
        private void nazivSkladistatxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(nazivSkladistatxt.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(nazivSkladistatxt, Global.GetMessage("required"));
            }
            else
                errorProvider.SetError(nazivSkladistatxt, "");
        }

        private void adresaSkladistatxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(adresaSkladistatxt.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(adresaSkladistatxt, Global.GetMessage("required"));
            }
            else
                errorProvider.SetError(adresaSkladistatxt, "");
        }
        private void opisSkladistatxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(opisSkladistatxt.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(opisSkladistatxt, Global.GetMessage("required"));
            }
            else
                errorProvider.SetError(opisSkladistatxt, "");
        }
        #endregion


    }
}
