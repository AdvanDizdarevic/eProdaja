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
using eProdaja_UI.Util;

namespace eProdaja_UI.Users
{
    public partial class EditForm : MetroFramework.Forms.MetroForm
    {

        WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:60271/", "api/Korisnici");
        WebAPIHelper ulogeservice = new WebAPIHelper("http://localhost:60271/", "api/Uloge");

        private int korisnikID { get; set; }

        private Korisnici k = new Korisnici();

        public EditForm(int selektedkorisnikid)
        {
            InitializeComponent();
            korisnikID = selektedkorisnikid;
        }

        private void EditFormcs_Load(object sender, EventArgs e)
        {
            //this.AutoValidate = AutoValidate.Disable;

            k = GetKorisnik(korisnikID);
       
            txtIme.Text = k.Ime;
            txtPrezime.Text = k.Prezime;
            txtEmail.Text = k.Email;
            txtTelef.Text = k.Telefon;
            txtUsername.Text = k.KorisnickoIme;
            txtPassword.Text = k.LozinkaHash;
            chkAktivan.Checked = k.Status;

            BindUloge();
        }

        private void BindUloge()
        {
            HttpResponseMessage response = ulogeservice.getResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Uloge> uloge = response.Content.ReadAsAsync<List<Uloge>>().Result;
                chkListUloge.DataSource = uloge;
                chkListUloge.DisplayMember = "Naziv";
                chkListUloge.ValueMember = "UlogaID";
                HttpResponseMessage response1 = ulogeservice.getActionResponse("GetByKorisnikId", k.KorisnikID.ToString());
                if (response1.IsSuccessStatusCode)
                {
                    List<KorisniciUloge> ulogeKorisnika = response1.Content.ReadAsAsync<List<KorisniciUloge>>().Result;

                    List<Uloge> novaLista = new List<Uloge>();

                    foreach (KorisniciUloge x in ulogeKorisnika)
                    {
                        foreach (Uloge y in uloge)
                        {
                            if (x.UlogaID == y.UlogaID)
                                novaLista.Add(y);
                        }
                    }

                    for (int i = 0; i < chkListUloge.Items.Count; i++)
                    {
                        if (novaLista.Contains(chkListUloge.Items[i]))
                            chkListUloge.SetItemCheckState(i, CheckState.Checked);
                    }
                }
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"), Global.GetMessage("warning"));
            }

        }

        private Korisnici GetKorisnik(int korisnikId)
        {
            HttpResponseMessage response = korisniciService.getResponse(korisnikId.ToString());
            if (response.IsSuccessStatusCode)
            {
                Korisnici k = response.Content.ReadAsAsync<Korisnici>().Result;
                return k;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"), Global.GetMessage("warning"));
                return null;
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Korisnici noviKorisnik = new Korisnici();
                noviKorisnik.KorisnikID = k.KorisnikID;
                noviKorisnik.Ime = txtIme.Text;
                noviKorisnik.Prezime = txtPrezime.Text;
                noviKorisnik.Email = txtEmail.Text;
                noviKorisnik.KorisnickoIme = txtUsername.Text;
                noviKorisnik.Telefon = txtTelef.Text;
                noviKorisnik.Status = chkAktivan.Checked;
                if (String.Compare(k.LozinkaHash, txtPassword.Text, StringComparison.Ordinal) != 1)
                {
                    noviKorisnik.LozinkaSalt = UIHelper.GenerateSalt();
                    noviKorisnik.LozinkaHash = UIHelper.GeneratHash(txtPassword.Text, noviKorisnik.LozinkaSalt);
                }
                else
                {
                    noviKorisnik.LozinkaHash = k.LozinkaHash;
                    noviKorisnik.LozinkaSalt = k.LozinkaSalt;
                }

                noviKorisnik.Uloge = chkListUloge.CheckedItems.Cast<Uloge>().ToList();
                //  noviKorisnik.KorisniciUloge = k.KorisniciUloge;

                HttpResponseMessage response = korisniciService.putResponse(noviKorisnik.KorisnikID, noviKorisnik);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Uspješno ste izvršili promjene!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show(Global.GetMessage("api_error"), Global.GetMessage("warning"));
            }
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
        private void txtTelef_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtTelef.Text)||!txtTelef.MaskCompleted)
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelef, Global.GetMessage("required"));
            }
            else
            {
                errorProvider.SetError(txtTelef, "");
            }
        }
        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtUsername, Global.GetMessage("required"));
            }
            else
            {
                errorProvider.SetError(txtUsername, "");
            }
        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPassword, Global.GetMessage("required"));
            }
            else
            {
                errorProvider.SetError(txtPassword, "");
            }
        }

        #endregion


    }
}
