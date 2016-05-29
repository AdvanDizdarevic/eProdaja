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

namespace eProdaja_UI
{
    public partial class KOrisniciForm : Form
    {

        WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:60271/", "api/Korisnici");

        public KOrisniciForm()
        {
            InitializeComponent();
        }

        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = korisniciService.getResponse();

            if (response.IsSuccessStatusCode)
            {
                List<Korisnici> korisnici = response.Content.ReadAsAsync<List<Korisnici>>().Result;
                dgv_apiKorisnici.DataSource = korisnici;
            }
            else
            {
                MessageBox.Show("Error code" + response + "Message" + response.ReasonPhrase);
            }
        }
    }
}
