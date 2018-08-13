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
using eProdaja_UI.Util;

namespace eProdaja_UI.Products
{
    public partial class EditCategory : MetroFramework.Forms.MetroForm
    {

        WebAPIHelper vrstaService = new WebAPIHelper("http://localhost:60271/", "api/KategorijeProizvoda");
        private int kategorijaId;
        public EditCategory(int katId)
        {
            InitializeComponent();
            kategorijaId = katId;
        }

        private void EditCategory_Load(object sender, EventArgs e)
        {
            KategorijeProizvoda kategorija = GetKategorija();
            txtNazivkategorije.Text = kategorija.Naziv;
            chkAktivna.Checked = kategorija.Status;
        }

        private KategorijeProizvoda GetKategorija()
        {
            if (kategorijaId > 0)
            {
                HttpResponseMessage response = vrstaService.getActionResponse(kategorijaId.ToString());
                if (response.IsSuccessStatusCode)
                {
                    KategorijeProizvoda k = response.Content.ReadAsAsync<KategorijeProizvoda>().Result;
                    return k;
                }
                else
                {
                    MessageBox.Show(Global.GetMessage("api_error"));
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KategorijeProizvoda k = GetKategorija();
            k.Naziv = txtNazivkategorije.Text;
            k.Status = chkAktivna.Checked;
            HttpResponseMessage response = vrstaService.putResponse(kategorijaId, k);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(Global.GetMessage("success"));
                this.Close();
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
            }
        }

        private void txtNazivkategorije_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNazivkategorije.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNazivkategorije, Global.GetMessage("required"));
            }
            else
            {
                errorProvider1.SetError(txtNazivkategorije, "");
            }
        }
    }
}
