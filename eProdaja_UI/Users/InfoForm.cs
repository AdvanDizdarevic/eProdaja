using eProdaja_API.Models;
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

namespace eProdaja_UI.Users
{
    public partial class InfoForm : Form
    {


        WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:60271/", "api/Korisnici");

        public InfoForm()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private void KorisniciForm_Load(object sender, EventArgs e)
        {


            loadData();

        }

        private void loadData()
        {
            HttpResponseMessage response = korisniciService.getActionResponse("SearchKorisnici", txtImePrezime.Text.Trim());
            if (response.IsSuccessStatusCode)
            {
                List<Korisnici> korisnici = response.Content.ReadAsAsync<List<Korisnici>>().Result;
                dgvKorisnici.DataSource = korisnici;
            }
            else
            {
                MessageBox.Show("Error code" + response + "Message" + response.ReasonPhrase);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {

            loadData();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Users.AddForm form = new AddForm();
            form.Show();
            

        }
    }
}