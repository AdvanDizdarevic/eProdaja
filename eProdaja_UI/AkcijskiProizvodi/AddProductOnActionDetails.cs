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
using System.Windows.Forms.VisualStyles;
using eProdaja_API.Models;
using eProdaja_UI.Util;

namespace eProdaja_UI.AkcijskiProizvodi
{
    public partial class AddProductOnActionDetails : MetroFramework.Forms.MetroForm
    {
        private WebAPIHelper proizvodiService = new WebAPIHelper("http://localhost:60271/", "api/Proizvodi");
        public Proizvodi proizvod { get; set; }
        private int proizvodID = 0;
        private List<string> procenti;
        public decimal popust;
        public DateTime datum;

        public AddProductOnActionDetails(int id)
        {
            InitializeComponent();
            proizvodID = id;
            datumKrajaAkcijeDtp.Value = DateTime.Now.AddDays(1);
        }

        private void AddProductOnActionDetails_Load(object sender, EventArgs e)
        {

            BindProizvodData();
        }

        private void BindProizvodData()
        {
            HttpResponseMessage response = proizvodiService.getActionResponse(proizvodID.ToString());
            if (response.IsSuccessStatusCode)
            {
                proizvod = response.Content.ReadAsAsync<Proizvodi>().Result;
                sifraProizvodaLbl.Text = proizvod.Sifra;
                nazivProizvodaLbl.Text = proizvod.Naziv;
                BindProcenti();
                popustCmb.DataSource = procenti;

            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
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


        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                popust = GetPopust();
                datum = datumKrajaAkcijeDtp.Value;
                this.Close();
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
                    MessageBox.Show("Morate odabrati nesto!");
                    break;
            }
            return vrati;
        }


        private void popustCmb_Validating(object sender, CancelEventArgs e)
        {
            if (popustCmb.SelectedIndex==0 || popustCmb.SelectedIndex==-1)
            {
                e.Cancel = true;
                errorProvider1.SetError(popustCmb, Global.GetMessage("popust_err"));
            }
            else
            {
                errorProvider1.SetError(popustCmb, "");
            }
        }

        private void datumKrajaAkcijeDtp_Validating(object sender, CancelEventArgs e)
        {
            if (datumKrajaAkcijeDtp.Value < DateTime.Now)
            {
                e.Cancel = true;
                errorProvider1.SetError(datumKrajaAkcijeDtp, Global.GetMessage("datum_err"));
            }
            else
            {
                errorProvider1.SetError(datumKrajaAkcijeDtp, "");
            }
        }
    }

}
