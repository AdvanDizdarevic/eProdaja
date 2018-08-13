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
using eProdaja_UI.Supliers;
using eProdaja_UI.Util;

namespace eProdaja_UI.Products
{
    public partial class PurchaseForm : MetroFramework.Forms.MetroForm
    {

        WebAPIHelper skladisteService = new WebAPIHelper("http://localhost:60271/","api/Skladista");
        WebAPIHelper proizvodiService = new WebAPIHelper("http://localhost:60271/", "api/Proizvodi");
        WebAPIHelper ulaziService = new WebAPIHelper("http://localhost:60271/", "api/Ulazi");

        private List<UlazStavke> ulaziStavke = new List<UlazStavke>();
        private Proizvodi proizv;
        private decimal iznos = 0;
        private decimal pdv = 0;

        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchSupplierFrom pretraziDobavljac = new SearchSupplierFrom();
            DialogResult dialogResult = pretraziDobavljac.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                textNaziv.Text = Global.odabraniDobavljac.Naziv;
                textKontakt.Text = Global.odabraniDobavljac.KontaktOsoba;
                textTelefon.Text = Global.odabraniDobavljac.Telefon;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("item_sel_err"));
            }
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            LoadSkladiste();
        }

        private void LoadSkladiste()
        {
            HttpResponseMessage response = skladisteService.getResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Skladista> skladista = response.Content.ReadAsAsync<List<Skladista>>().Result;
                skladista.Insert(0,new Skladista());
                comboSkladiste.DataSource = skladista;
                comboSkladiste.ValueMember = "SkladisteID";
                comboSkladiste.DisplayMember = "Naziv";
            }
            else
            {
                MessageBox.Show(Global.GetMessage("item_sel_err"));
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (textKolicina.Text != "000" && textCijena.Text != "0000.00" && textKolicina.Text != "" && textCijena.Text != "")
            DodajStavku();
            else
            {
                MessageBox.Show("Unesite cijenu i kolicinu");
            }
            BindGrid();
        }

        private void BindGrid()
        {
            gridSkladista.ClearSelection();
            gridSkladista.AutoGenerateColumns = false;
            gridSkladista.DataSource = null;
           
            gridSkladista.DataSource = ulaziStavke;
            gridSkladista.ClearSelection();
        }

        private void DodajStavku()
        {
            try
            {
                UlazStavke s = new UlazStavke();
                bool stop = false;
                GetProizvodBySifra();
                s.ProizvodID = proizv.ProizvodID;
                s.Proizvodi = proizv;

                s.Kolicina = Convert.ToInt32(textKolicina.Text);
                s.Cijena = Convert.ToDecimal(textCijena.Text);
                foreach (UlazStavke u in ulaziStavke)
                {
                    if (u.ProizvodID == s.ProizvodID)
                    {
                        u.Kolicina += Convert.ToInt32(textKolicina.Text);
                        stop = true;
                    }
                }
                if (textSifraProizvoda.Text != "" )
                {
                    if (!stop)

                       ulaziStavke.Add(s);

                iznos += s.Kolicina*s.Cijena;
                pdv = (decimal) 0.17*iznos;
                textIznos.Text = Math.Round(iznos + pdv, 2).ToString();
                textPDV.Text = Math.Round(pdv, 2).ToString();

                textSifraProizvoda.Text = "";
                textKolicina.Text = "000";
                textCijena.Text = "0000.00";
                textSifraProizvoda.Focus();
            }
        else
            {
                MessageBox.Show("Niste odabrali proizvod");
            }


        }
            catch (Exception ex)
            {
                MessageBox.Show("Niste unijeli cijenu i kolicinu proizvoda!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetProizvodBySifra()
        {
            HttpResponseMessage response = proizvodiService.getActionResponse("GetProizvodBySifra",
                textSifraProizvoda.Text.Trim());
            if (response.IsSuccessStatusCode)
            {
                proizv = response.Content.ReadAsAsync<Proizvodi>().Result;
            }
            else
            {
                MessageBox.Show("Proizvod sa sifrom"+ textSifraProizvoda.Text + "ne postoji");
            }
        }

        private void btn_ukloniProizvod_Click(object sender, EventArgs e)
        {
            if (gridSkladista.Rows.Count > 0 && ulaziStavke.Count>0)
            {
                decimal cijenaProizvoda = ulaziStavke[(gridSkladista.CurrentCell.RowIndex)].Kolicina*
                                          ulaziStavke[(gridSkladista.CurrentCell.RowIndex)].Cijena;
                iznos -= Math.Round(cijenaProizvoda, 2);

                ulaziStavke.RemoveAt(gridSkladista.CurrentCell.RowIndex);

                pdv = (decimal) 0.17*iznos;
                textIznos.Text = Math.Round(iznos + pdv, 2).ToString();
                textPDV.Text = Math.Round(pdv, 2).ToString();
                BindGrid();
            }
            else
            {
                MessageBox.Show("Odaberite proizvod koji zelite obrisati sa liste");
            }
        }
        private void btnTraziProizvod_Click(object sender, EventArgs e)
        {
            using (ProductSearchForm pretraziProizvodForm = new ProductSearchForm())
            {
                if (pretraziProizvodForm.ShowDialog() == DialogResult.OK)
                {
                    textSifraProizvoda.Text = pretraziProizvodForm.sifraProizvod;
                }
            }
        }


        private void btnZakljuci_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                try
                {
                    Ulazi ulaz = new Ulazi();

                    ulaz.DobavljacID = Global.odabraniDobavljac.DobavljacID;
                    ulaz.KorisnikID = Global.prijavljeniKorisnik.KorisnikID;

                    if (comboSkladiste.SelectedIndex != 0)
                        ulaz.SkladisteID = Convert.ToInt32(comboSkladiste.SelectedValue);
                    ulaz.BrojFakture = textBrFakture.Text;
                    ulaz.Datum = dateTimePicker.Value;
                    ulaz.Napomena = textNapomena.Text;
                    ulaz.IznosRacuna = iznos + pdv;
                    ulaz.PDV = pdv;

                    foreach (UlazStavke stavke in ulaziStavke)
                    {
                        ulaz.UlazStavkes.Add(stavke);
                    }

                    HttpResponseMessage response = ulaziService.postResponse(ulaz);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Global.GetMessage("success"));
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show(Global.GetMessage("api_error"),Global.GetMessage("warning"),MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Global.GetMessage("warning"), MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        #region Validation

        private void comboSkladiste_Validating(object sender, CancelEventArgs e)
        {
            if (comboSkladiste.SelectedIndex == 0 || comboSkladiste.SelectedIndex == -1)
            {
                e.Cancel = true;

                errorProvider1.SetError(comboSkladiste, Global.GetMessage("skladiste_err"));
            }
            else
            {
                errorProvider1.SetError(comboSkladiste, "");
            }
        }

        private void textBrFakture_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBrFakture.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBrFakture, Global.GetMessage("required"));
            }
            else
            {
                errorProvider1.SetError(textBrFakture, "");
            }
        }

    

        private void textCijena_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                DodajStavku();
                BindGrid();
            }
        }

        private void gridSkladista_Validating(object sender, CancelEventArgs e)
        {
            if (ulaziStavke.Count == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(gridSkladista, Global.GetMessage("list_error"));
                MessageBox.Show("Niste odabrali ni jedan proizvod");
            }
            else
            {
                errorProvider1.SetError(gridSkladista, "");
            }
        }

        private void dateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePicker.Value < DateTime.Today)
            {
                e.Cancel = true;
                errorProvider1.SetError(dateTimePicker, Global.GetMessage("datum_err"));
            }
            else
            {
                errorProvider1.SetError(dateTimePicker, "");
            }
        }
        private void button1_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textNaziv.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textNaziv, Global.GetMessage("required"));
            }
            else
            {
                errorProvider1.SetError(textNaziv, "");
            }
        }
        //private void btnDodaj_Validating(object sender, CancelEventArgs e)
        //{
        //    if (String.IsNullOrEmpty(textKolicina.Text) || textKolicina.Text == "000" || String.IsNullOrEmpty(textCijena.Text) || textCijena.Text == "0000.00" )
        //    {
        //        e.Cancel = true;
        //        errorProvider1.SetError(textKolicina, Global.GetMessage("required"));
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(textKolicina, "");
        //    }
        //}
        private void textKolicina_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textKolicina.Text) || textKolicina.Text == "000")
            {
                e.Cancel = true;
                errorProvider1.SetError(textKolicina, Global.GetMessage("required"));
            }
            else
            {
                errorProvider1.SetError(textKolicina, "");
            }
        }

        private void textCijena_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textCijena.Text) || textCijena.Text == "0000.00")
            {
                e.Cancel = true;
                errorProvider1.SetError(textCijena, Global.GetMessage("required"));
            }
            else
            {
                errorProvider1.SetError(textCijena, "");
            }
        }
        #endregion

      

  

     

     

     


    }
}
