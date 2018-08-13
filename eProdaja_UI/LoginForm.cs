using eProdaja_API.Models;
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
using eProdaja_UI.Util;


namespace eProdaja_UI
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {

        WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:60271/", "api/Korisnici");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prijavaBtn_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = korisniciService.getActionResponse("GetKorisniciByUsername", txtKorisnickoIme.Text);
            if(response.IsSuccessStatusCode)
            {
                Korisnici k = response.Content.ReadAsAsync<Korisnici>().Result;
                if (UIHelper.GeneratHash(txtLozinkaH.Text, k.LozinkaSalt) == k.LozinkaHash)
                {
                    Global.prijavljeniKorisnik = k; 
                    this.DialogResult = DialogResult.OK; 
                    this.Close();
                }
                else
                    MessageBox.Show(Global.GetMessage("login_pass_err"),Global.GetMessage("warning"),MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Greska oko validacije : Error code" + response + "Message" + response.ReasonPhrase);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtKorisnickoIme.Text = "desktop";
            txtLozinkaH.Text = "test";
        }
    }
}
