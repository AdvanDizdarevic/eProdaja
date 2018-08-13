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


namespace eProdaja_UI.AkcijskiProizvodi
{
    public partial class EditProductOnAction : MetroFramework.Forms.MetroForm
    {
        private WebAPIHelper akcijskiProizvodiService = new WebAPIHelper("http://localhost:60271/", "api/AkcijskiProizvodi");
        private eProdaja_API.Models.AkcijskiProizvodi akcijskiProizvod { get; set; }
        private int akcijskiProizvodID = 0;
        private string nazivProizvoda;
        private string sifraProizvoda;
        private List<string> procenti;

        public EditProductOnAction(int akcijskiProizvodId, string naziv, string sifra)
        {
            InitializeComponent();
            akcijskiProizvodID = akcijskiProizvodId;
            nazivProizvoda = naziv;
            sifraProizvoda = sifra;
        }

        private void EditProductOnAction_Load(object sender, EventArgs e)
        {
            BindProizvod();
        }

        private void BindProizvod()
        {
            HttpResponseMessage response = akcijskiProizvodiService.getActionResponse(akcijskiProizvodID.ToString());
            if (response.IsSuccessStatusCode)
            {
                akcijskiProizvod = response.Content.ReadAsAsync<eProdaja_API.Models.AkcijskiProizvodi>().Result;
                nazivProizvodaLbl.Text = nazivProizvoda;
                sifraProizvodaLbl.Text = sifraProizvoda;
                datumPocetkaAkcijeDtp.Value = akcijskiProizvod.DatumPocetka;
                datumKrajaAkcijeDtp.Value = akcijskiProizvod.DatumKraja;
                popustTxt.Text = akcijskiProizvod.Popust.ToString();
                statusChb.Checked = akcijskiProizvod.Status.Value;
                popustCmb.ValueMember= akcijskiProizvod.Status.Value.ToString();
                BindProcenti();
                popustCmb.DataSource = procenti;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
                this.Close();
            }
        }

        private void BindProcenti()
        {
            procenti = new List<string>();

            procenti.Add("");
            for (int i = 10; i < 100; i += 10)
            {
                procenti.Add(i + "%");
            }
        }

        private decimal GetPopust()
        {
            string a = popustCmb.SelectedValue.ToString();
            decimal vrati = 0m;
            switch (a)
            {
                case "10%":
                    vrati = 0.1m;
                    break;
                case "20%":
                    vrati = 0.2m;
                    break;
                case "30%":
                    vrati = 0.3m;
                    break;
                case "40%":
                    vrati = 0.4m;
                    break;
                case "50%":
                    vrati = 0.5m;
                    break;
                case "60%":
                    vrati = 0.6m;
                    break;
                case "70%":
                    vrati = 0.7m;
                    break;
                case "80%":
                    vrati = 0.8m;
                    break;
                case "90%":
                    vrati = 0.9m;
                    break;
                default:
                    MessageBox.Show("Niste odabrali popust!");
                    break;
            }
            return vrati;
        }

        private void spasiPromjeneBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                akcijskiProizvod.DatumPocetka = datumPocetkaAkcijeDtp.Value;
                akcijskiProizvod.DatumKraja = datumKrajaAkcijeDtp.Value;
                //akcijskiProizvod.Popust = Convert.ToDecimal(popustTxt.Text);
                akcijskiProizvod.Popust = GetPopust();
                akcijskiProizvod.Status = statusChb.Checked;
                HttpResponseMessage response = akcijskiProizvodiService.putResponse(akcijskiProizvodID,
                    akcijskiProizvod);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Global.GetMessage("success"));
                    this.Close();
                }
                else
                    MessageBox.Show(Global.GetMessage("api_error"));
            }
        }

        private void popustTxt_Validating(object sender, CancelEventArgs e)
        {
          
            if (String.IsNullOrEmpty(popustTxt.Text.Trim()))
            {

                e.Cancel = true;
                errorProvider1.SetError(popustTxt, Global.GetMessage("required"));

            }
            else
                errorProvider1.SetError(popustTxt, "");
        }

     

        private void popustCmb_Validating(object sender, CancelEventArgs e)
        {
            if (popustCmb.SelectedIndex <=0)
            {
                e.Cancel = true;
                errorProvider1.SetError(popustCmb, Global.GetMessage("popust_err"));
            }
            else
            {
                errorProvider1.SetError(popustCmb, "");
            }
        }
    }
    }

