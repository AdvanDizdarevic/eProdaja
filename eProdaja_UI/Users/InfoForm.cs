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
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace eProdaja_UI.Users
{
    public partial class InfoForm : MetroFramework.Forms.MetroForm
    {


        WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:60271/", "api/Korisnici");

        public InfoForm()
        {
            InitializeComponent();
            megrtoGrid.AutoGenerateColumns = false;
        }

        private void KorisniciForm_Load(object sender, EventArgs e)
        {


            GetAktivniKorisnici();

        }

        private void GetAktivniKorisnici()
        {

            HttpResponseMessage response = korisniciService.getResponse("GetAktivni");
            if (response.IsSuccessStatusCode)
            {
                List<Korisnici> korisnici = response.Content.ReadAsAsync<List<Korisnici>>().Result;
                megrtoGrid.DataSource = korisnici;
            }
            else
            {
                MessageBox.Show("Error code" + response + "Message" + response.ReasonPhrase);
            }
        }

        private void loadData()
        {
            HttpResponseMessage response = korisniciService.getActionResponse("SearchKorisnici", txtImePrezime.Text.Trim());
            if (response.IsSuccessStatusCode)
            {
                List<Korisnici> korisnici = response.Content.ReadAsAsync<List<Korisnici>>().Result;
                megrtoGrid.DataSource = korisnici;
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

        //private void dgvKorisnici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (megrtoGrid.Rows.Count == 0)
        //    {
        //        MessageBox.Show(Global.GetMessage("item_select_err"));
        //    }
        //    else
        //    {
        //        int korisnikID = Convert.ToInt32(megrtoGrid.SelectedRows[0].Cells[0].Value.ToString());
        //        if (korisnikID > 0)
        //        {
        //            EditForm urediKorisnika = new EditForm(korisnikID);
        //            urediKorisnika.Show();
        //        }
        //    }
        //}

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (megrtoGrid.Rows.Count == 0)
            {
                MessageBox.Show(Global.GetMessage("item_select_err"),Global.GetMessage("warning"));
            }
            else
            {
                int korisnikid = Convert.ToInt32(megrtoGrid.SelectedRows[0].Cells[0].Value.ToString());
                if (korisnikid > 0)
                {
                    HttpResponseMessage response1 = korisniciService.getActionResponse("GetKorisniciStatus",
                        korisnikid.ToString());
                    bool status = response1.Content.ReadAsAsync<bool>().Result;
                    if (!status)
                    {
                        MessageBox.Show("Korisnik vec izbrisan!!");
                    }
                    else
                    {


                        HttpResponseMessage response = korisniciService.DeleteResponse(korisnikid);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show(Global.GetMessage("item_del_succ"));
                            GetAktivniKorisnici();
                        }
                        else
                        {
                            MessageBox.Show(Global.GetMessage("api_error"), Global.GetMessage("warning"));
                        }

                    }
                }
                else
                {
                    MessageBox.Show(Global.GetMessage("item_select_err"), Global.GetMessage("warning"));
                }
            }
        }

        private void btnObrisani_Click(object sender, EventArgs e)
        {
            GetNeaktivni();
        }

        private void GetNeaktivni()
        {

            HttpResponseMessage response = korisniciService.getResponse("GetNeaktivni");
            if (response.IsSuccessStatusCode)
            {
                List<Korisnici> korisnici = response.Content.ReadAsAsync<List<Korisnici>>().Result;
                megrtoGrid.DataSource = korisnici;
            }
            else
            {
                MessageBox.Show("Error code" + response + "Message" + response.ReasonPhrase);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetAktivniKorisnici();
        }

        private void megrtoGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (megrtoGrid.Rows.Count == 0)
            {
                MessageBox.Show(Global.GetMessage("item_select_err"));
            }
            else
            {
                int korisnikID = Convert.ToInt32(megrtoGrid.SelectedRows[0].Cells[0].Value.ToString());
                if (korisnikID > 0)
                {
                    EditForm urediKorisnika = new EditForm(korisnikID);
                    urediKorisnika.Show();
                }
            }
        }
    }
}