using eProdaja_API.Models;
using eProdaja_UI.Util;
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

namespace eProdaja_UI.Users
{
    public partial class AddForm : Form
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
            this.AutoValidate = AutoValidate.Disable;
        }

        private void BindUloge()
        {
            HttpResponseMessage response = ulogeservice.getResponse();
            if(response.IsSuccessStatusCode)
            {
                ((ListBox)ulogeList).DataSource = response.Content.ReadAsAsync<List<Uloge>>().Result;
                ((ListBox)ulogeList).DisplayMember = "Naziv";
                ((ListBox)ulogeList).ValueMember = "UlogaID";
                ulogeList.ClearSelected();
            }
        }
        
        private void btnDodajNovi_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
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

                HttpResponseMessage response = korisniciService.postResponse(k);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Korisnik uspjesno dodat! (" + response.Content.ReadAsAsync<Korisnici>().Result.KorisnikID + ")");
                    clearInput();
                }
                else
                {
                    MessageBox.Show("Error code- " + response.StatusCode+ Environment.NewLine  + " Message- " + response.ReasonPhrase);
                }
            }
         
        }

        private void clearInput()
        {
            txtIme.Text = txtPrezime.Text = txtLozinkaH.Text = txtTelefon.Text = txtEmail.Text = txtKorisnickoIme.Text = "";
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(txtIme.Text))
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
    }
   }

