using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eProdaja_API.Models;
using eProdaja_PCL.Util;
using eProdaja_UI;


namespace eProdaja_UI.Supliers
{
    public partial class EditSupplier : MetroFramework.Forms.MetroForm
    {
        private WebAPIHelper dobavljaciService = new WebAPIHelper("http://localhost:60271/", "api/Dobavljaci");
        private Dobavljaci dobavljac { get; set; }
        private int supplierID;

        public EditSupplier(int id)
        {
            InitializeComponent();
            supplierID = id;
        }

        private void EditSupplier_Load(object sender, EventArgs e)
        {
            GetDobavljac();
            NapuniPodatke();
        }

        private void NapuniPodatke()
        {
            nazivInputtxt.Text = dobavljac.Naziv;
            kontaktOsobaInputtxt.Text = dobavljac.KontaktOsoba;
            adresaInputtxt.Text = dobavljac.Adresa;
            telefonInputtxt.Text = dobavljac.Telefon;
            faksInputtxt.Text = dobavljac.Fax;
            mailInputtxt.Text = dobavljac.Email;
            webInputtxt.Text = dobavljac.Web;
            ziroRacunInputtxt.Text = dobavljac.ZiroRacuni;
            statuschb.Checked = dobavljac.Status;
            napomenaInputtxt.Text = dobavljac.Napomena;
        }

        private void GetDobavljac()
        {
            if (supplierID > 0)
            {
                HttpResponseMessage response = dobavljaciService.getActionResponse(supplierID.ToString());
                if (response.IsSuccessStatusCode)
                {
                    dobavljac = response.Content.ReadAsAsync<Dobavljaci>().Result;
                }
                else
                {
                    MessageBox.Show(Global.GetMessage("api_error"), Global.GetMessage("warning"));
                    this.Close();
                }
            }
        }

        private void spasiPromjenebtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren()){

                dobavljac.Naziv = nazivInputtxt.Text;
            dobavljac.KontaktOsoba = kontaktOsobaInputtxt.Text;
            dobavljac.Adresa = adresaInputtxt.Text;
            dobavljac.Telefon = telefonInputtxt.Text;
            dobavljac.Fax = faksInputtxt.Text;
            dobavljac.Email = mailInputtxt.Text;
            dobavljac.Web = webInputtxt.Text;
            dobavljac.ZiroRacuni = ziroRacunInputtxt.Text;
            dobavljac.Status = statuschb.Checked;
            dobavljac.Napomena = napomenaInputtxt.Text;
            HttpResponseMessage response = dobavljaciService.putResponse(supplierID, dobavljac);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(Global.GetMessage("success"), Global.GetMessage("info"));
                this.Close();
            }
            else
                MessageBox.Show(Global.GetMessage("api_error"), Global.GetMessage("warning"));
        }
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

    }
}
