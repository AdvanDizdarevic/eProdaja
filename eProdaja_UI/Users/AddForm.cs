using eProdaja_API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eProdaja_UI;
using eProdaja_UI.Util;


namespace eProdaja_UI.Users
{
    public partial class AddForm : MetroFramework.Forms.MetroForm
    {
        WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:60271/", "api/Korisnici");
        WebAPIHelper ulogeservice = new WebAPIHelper("http://localhost:60271/", "api/Uloge");

        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            BindUloge();


        }

        private void BindUloge()
        {
            HttpResponseMessage response = ulogeservice.getResponse();
            if (response.IsSuccessStatusCode)
            {
                ((ListBox) ulogeList).DataSource = response.Content.ReadAsAsync<List<Uloge>>().Result;
                ((ListBox) ulogeList).DisplayMember = "Naziv";
                ((ListBox) ulogeList).ValueMember = "UlogaID";
                ulogeList.ClearSelected();
            }
        }

        private void btnDodajNovi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Korisnici k = new Korisnici();
                k.Ime = txtIme.Text;
                k.Prezime = txtIme.Text;
                k.Telefon = txtTelefon.Text;
                k.Email = txtEmail.Text;
                k.LozinkaSalt = UIHelper.GenerateSalt();
                k.LozinkaHash = UIHelper.GeneratHash(txtLozinkaH.Text, k.LozinkaSalt);
                k.Status = true;
                k.KorisnickoIme = txtKorisnickoIme.Text;

                k.Uloge = ulogeList.CheckedItems.Cast<Uloge>().ToList();

                HttpResponseMessage response1 = korisniciService.getActionResponse(
                    "GetKorisniciByUsername", txtKorisnickoIme.Text.Trim());
                if (response1.IsSuccessStatusCode)
                {
                    MessageBox.Show("Korisnik sa Korisnickim imenom <" + txtKorisnickoIme.Text +
                                    "> već postoji u bazi podataka!");
                }
                else if (response1.StatusCode == HttpStatusCode.NotFound)
                {
                    HttpResponseMessage response = korisniciService.postResponse(k);
                    if (response.IsSuccessStatusCode)
                    {
                        DialogResult dialog = MessageBox.Show("Korisnik uspjesno dodan < (" +
                                                              response.Content.ReadAsAsync<Korisnici>().Result.Ime +
                                                              ")> Da li zelite dodati novog korisnika?", "Poruka",
                            MessageBoxButtons.YesNo);
                        if (dialog == DialogResult.Yes)
                            clearInput();
                        else
                            this.Close();

                    }
                    else
                    {
                        MessageBox.Show(Global.GetMessage("api_error"), Global.GetMessage("warning"));
                    }
                }
                else
                {
                    MessageBox.Show(Global.GetMessage("api_error"), Global.GetMessage("warning"));
                }
            }

        }

        private void clearInput()
        {
            txtIme.Text =
                txtPrezime.Text = txtLozinkaH.Text = txtTelefon.Text = txtEmail.Text = txtKorisnickoIme.Text = "";
        }

        #region Validacija 

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtIme.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtIme, Global.GetMessage("fname_req"));
            }
            else
            {
                errorProvider.SetError(txtIme, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, Global.GetMessage("email_req"));

            }
            else
            {
                try
                {
                    MailAddress mail = new MailAddress(txtEmail.Text);
                    errorProvider.SetError(txtEmail, "");
                }
                catch (Exception)
                {

                    e.Cancel = true;
                    errorProvider.SetError(txtEmail, Global.GetMessage("email_err"));
                }
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtPrezime.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPrezime, Global.GetMessage("required"));
            }
            else
            {
                errorProvider.SetError(txtPrezime, "");
            }

        }


        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtKorisnickoIme.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtKorisnickoIme, Global.GetMessage("required"));
            }
            else
            {
                errorProvider.SetError(txtKorisnickoIme, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtLozinkaH.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtLozinkaH, Global.GetMessage("required"));
            }
            else
            {
                errorProvider.SetError(txtLozinkaH, "");
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtTelefon.Text) || !txtTelefon.MaskCompleted)
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelefon, Global.GetMessage("required"));
            }
            else
            {
                errorProvider.SetError(txtTelefon, "");
            }

            #endregion



        }
    }
}
   

