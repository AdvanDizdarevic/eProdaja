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
    public partial class CategorijesInfo : MetroFramework.Forms.MetroForm
    {
        WebAPIHelper vrstaService = new WebAPIHelper("http://localhost:60271/", "api/KategorijeProizvoda");

        public CategorijesInfo()
        {
            InitializeComponent();
        }

        private void dodajKategoriju_Click(object sender, EventArgs e)
        {
            AddCategory dodajnovukateg = new AddCategory();
            dodajnovukateg.Show();
        }

        private void CategorijesInfo_Load(object sender, EventArgs e)
        {
            BindGridKateg();
        }

        private void BindGridKateg()
        {
            HttpResponseMessage response = vrstaService.getResponse();
            if (response.IsSuccessStatusCode)
            {
                dgvKategorije.AutoGenerateColumns = false;
                dgvKategorije.DataSource = response.Content.ReadAsAsync<List<KategorijeProizvoda>>().Result;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            BindGridKateg();
        }

        private void prikaziAktivne_Click(object sender, EventArgs e)
        {
            BindGridKategAktivne();
        }

        private void BindGridKategAktivne()
        {

            HttpResponseMessage response = vrstaService.getActionResponse("KategorijeAktivne");
            if (response.IsSuccessStatusCode)
            {
                dgvKategorije.AutoGenerateColumns = false;
                dgvKategorije.DataSource = response.Content.ReadAsAsync<List<KategorijeProizvoda>>().Result;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
            }
        }

        private void prikaziNeAktivne_Click(object sender, EventArgs e)
        {
            BindGridKategNeAktivne();
        }

        private void BindGridKategNeAktivne()
        {
            HttpResponseMessage response = vrstaService.getActionResponse("KategorijeNeaktivne");
            if (response.IsSuccessStatusCode)
            {
                dgvKategorije.AutoGenerateColumns = false;
                dgvKategorije.DataSource = response.Content.ReadAsAsync<List<KategorijeProizvoda>>().Result;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
            }
        }

        private void obrisiKategoriju_Click(object sender, EventArgs e)
        {
            int kategorijaId = Convert.ToInt32(dgvKategorije.SelectedRows[0].Cells[0].Value.ToString());
            if (kategorijaId > 0)
            {
                HttpResponseMessage response1 = vrstaService.getActionResponse("GetKategorijaStatus",
                      kategorijaId.ToString());
                bool status = response1.Content.ReadAsAsync<bool>().Result;
                if (!status)
                {
                    MessageBox.Show("Kategorija vec izbrisan!!");
                }
                else
                { 
                HttpResponseMessage response = vrstaService.DeleteResponse(kategorijaId);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Global.GetMessage("del_succ"));
                }
                else
                {
                    MessageBox.Show(Global.GetMessage("api_error"));
                }
            }
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
            }
        }

        //private void dgvKategorije_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dgvKategorije.Rows.Count == 0)
        //    {
        //        MessageBox.Show(Global.GetMessage("item_select_err"));
        //    }
        //    else
        //    {
        //        int kategorijaId = Convert.ToInt32(dgvKategorije.SelectedRows[0].Cells[0].Value.ToString());
        //        if (kategorijaId > 0)
        //        {
        //            EditCategory urediKorisnika = new EditCategory(kategorijaId);
        //            urediKorisnika.Show();
        //        }
        //    }
        //}

        private void dgvKategorije_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKategorije.Rows.Count == 0)
            {
                MessageBox.Show(Global.GetMessage("item_select_err"));
            }
            else
            {
                int kategorijaId = Convert.ToInt32(dgvKategorije.SelectedRows[0].Cells[0].Value.ToString());
                if (kategorijaId > 0)
                {
                    EditCategory urediKorisnika = new EditCategory(kategorijaId);
                    urediKorisnika.Show();
                }
            }

        }
    }
}
