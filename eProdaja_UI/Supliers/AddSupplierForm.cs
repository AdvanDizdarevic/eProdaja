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

using System.Net.Mail;
using eProdaja_API.Models;
using eProdaja_PCL.Util;

namespace eProdaja_UI.Supliers
{
    public partial class AddSupplierForm : MetroFramework.Forms.MetroForm
    {
        private WebAPIHelper dobavljaciService = new WebAPIHelper("http://localhost:60271/", "api/Dobavljaci");

        public AddSupplierForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void dodajDobavljacabtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Dobavljaci dobavljac = new Dobavljaci();
                dobavljac.Adresa = adresaInputtxt.Text;
                dobavljac.Email = mailInputtxt.Text;
                dobavljac.Fax = faksInputtxt.Text;
                dobavljac.KontaktOsoba = kontaktOsobaInputtxt.Text;
                dobavljac.Napomena = napomenaInputtxt.Text;
                dobavljac.Naziv = nazivInputtxt.Text;
                dobavljac.Status = statuschb.Checked;
                dobavljac.Telefon = telefonInputtxt.Text;
                dobavljac.Web = webInputtxt.Text;
                dobavljac.ZiroRacuni = ziroRacunInputtxt.Text;

                HttpResponseMessage response = dobavljaciService.postResponse(dobavljac);
                if (response.IsSuccessStatusCode)
                {
                    DialogResult dialogResult =
                        MessageBox.Show(
                            Global.GetMessage("sup_succ_info"), Global.GetMessage("info"),
                            MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                        ClearInputText();
                    else
                        this.Close();
                }
            }
        }

        private void ClearInputText()
        {
            adresaInputtxt.Text =
                mailInputtxt.Text =
                    faksInputtxt.Text =
                        kontaktOsobaInputtxt.Text =
                            napomenaInputtxt.Text =
                                nazivInputtxt.Text =
                                    telefonInputtxt.Text = webInputtxt.Text = ziroRacunInputtxt.Text = "";
            statuschb.Checked = false;
        }
        #region Validating
        private void nazivInputtxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(nazivInputtxt.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(nazivInputtxt, Global.GetMessage("required"));
            }
            else
                errorProvider.SetError(nazivInputtxt, "");
        }

        private void kontaktOsobaInputtxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(kontaktOsobaInputtxt.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(kontaktOsobaInputtxt, Global.GetMessage("required"));
            }
            else
                errorProvider.SetError(kontaktOsobaInputtxt, "");
        }

        private void adresaInputtxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(adresaInputtxt.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(adresaInputtxt, Global.GetMessage("required"));
            }
            else
                errorProvider.SetError(adresaInputtxt, "");
        }

        private void telefonInputtxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(telefonInputtxt.Text.Trim()) || !telefonInputtxt.MaskCompleted)
            {
                e.Cancel = true;
                errorProvider.SetError(telefonInputtxt, Global.GetMessage("required"));
            }
            else
                errorProvider.SetError(telefonInputtxt, "");
        }

        private void mailInputtxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(mailInputtxt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(mailInputtxt, Global.GetMessage("required"));
            }
            else
            {
                try
                {
                    MailAddress mail = new MailAddress(mailInputtxt.Text);
                    errorProvider.SetError(mailInputtxt, "");
                }
                catch (Exception)
                {
                    errorProvider.SetError(mailInputtxt, Global.GetMessage("required"));
                }
            }
        }

        private void ziroRacunInputtxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(ziroRacunInputtxt.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(ziroRacunInputtxt, Global.GetMessage("required"));
            }
            else
                errorProvider.SetError(ziroRacunInputtxt, "");
        }

        private void faksInputtxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(faksInputtxt.Text.Trim()) || !faksInputtxt.MaskCompleted)
            {
                e.Cancel = true;
                errorProvider.SetError(faksInputtxt, Global.GetMessage("required"));
            }
            else
                errorProvider.SetError(faksInputtxt, "");
        }

        private void webInputtxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(webInputtxt.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(webInputtxt, Global.GetMessage("required"));
            }
            else
                errorProvider.SetError(webInputtxt, "");
        }
        #endregion

        private void AddSupplierForm_Load(object sender, EventArgs e)
        {

        }
    }
}
