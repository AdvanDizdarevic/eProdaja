using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using eProdaja_API.Models;
using System.Net.Http;
using eProdaja_UI.Izvjestaji;
using eProdaja_UI.Util;


namespace eProdaja_UI.Orders
{
    public partial class DetailsForm : MetroFramework.Forms.MetroForm
    {
        WebAPIHelper serviceNarudzbe = new WebAPIHelper("http://localhost:60271/", "api/Narudzbe");
        WebAPIHelper serviceSkladista = new WebAPIHelper("http://localhost:60271/", "api/Skladista");
        WebAPIHelper serviceProizvodi = new WebAPIHelper("http://localhost:60271/", "api/Proizvodi");
        WebAPIHelper serviceNaruzdbaStavke = new WebAPIHelper("http://localhost:60271/", "api/NarudzbaStavke");
        WebAPIHelper izlaziservice = new WebAPIHelper("http://localhost:60271/", "api/Izlazis");

        public esp_Narudzbe_SelectAktivne_Result narudzba { get; set; }

        public DetailsForm(esp_Narudzbe_SelectAktivne_Result narudzba)
        {
            InitializeComponent();
            this.narudzba = narudzba;
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
       BindForm();
            BindSkladista();
        }

        private void BindSkladista()
        {
            HttpResponseMessage response = serviceSkladista.getResponse();

            if (response.IsSuccessStatusCode)
            {
                List<Skladista> skladista = response.Content.ReadAsAsync<List<Skladista>>().Result;
                skladista.Insert(0, new Skladista());
                skladistaList.DataSource = skladista;
                skladistaList.DisplayMember = "Naziv";
                skladistaList.ValueMember = "SkladisteID";
            }
        }

        private void BindForm()
        {
            brNarudzbeLabel.Text = narudzba.BrojNarudzbe;
            datumLabel.Text = narudzba.Datum.ToShortDateString();
            kupacLabel.Text = narudzba.Kupac;
            iznosNarudzbeLabel.Text = narudzba.Iznos.ToString() + "KM";

            HttpResponseMessage response = serviceNarudzbe.getActionResponse("GetStavkeNarudzbe", narudzba.NarudzbaID.ToString());

            if (response.IsSuccessStatusCode)
            {
                stavkeNarudzbeGrid.DataSource = response.Content.ReadAsAsync<List<esp_NarudzbaStavke_SelectByNarudzbaID_Result>>().Result;
                stavkeNarudzbeGrid.Columns[0].Visible = false;
                stavkeNarudzbeGrid.Columns[1].Visible = false;
                stavkeNarudzbeGrid.ClearSelection();
            }
        }

        private void procesirajButton_Click(object sender, EventArgs e)
        {

            if(this.ValidateChildren())
            { 
            List<esp_NarudzbaStavke_SelectByNarudzbaID_Result> narudzbaStavke = new List<esp_NarudzbaStavke_SelectByNarudzbaID_Result>();
            List<esp_Proizvodi_SelectBySkladiste_Result> proizvodiSkladiste = new List<esp_Proizvodi_SelectBySkladiste_Result>();
            bool nastavi = true;

            HttpResponseMessage response2 = serviceNarudzbe.getActionResponse("GetStavkeNarudzbe",
                narudzba.NarudzbaID.ToString());
            if (response2.IsSuccessStatusCode)
            {
                narudzbaStavke = response2.Content.ReadAsAsync<List<esp_NarudzbaStavke_SelectByNarudzbaID_Result>>().Result;
            }
            HttpResponseMessage response3 = serviceProizvodi.getActionResponse("GetProzivodBySkladiste", skladistaList.SelectedValue.ToString());
            if (response3.IsSuccessStatusCode)
            {
                proizvodiSkladiste = response3.Content.ReadAsAsync<List<esp_Proizvodi_SelectBySkladiste_Result>>().Result;
            }

            if (narudzbaStavke != null && proizvodiSkladiste != null)
                foreach (var n in narudzbaStavke)
                {
                    foreach (var p in proizvodiSkladiste)
                    {
                        if (n.ProizvodID == p.ProizvodID)
                        {
                            if (n.Kolicina > p.Kolicina)
                            {
                                DialogResult dialog = MessageBox.Show("Nemate dovoljno proizvoda ::" + p.Naziv + ":: na skladištu!" + Environment.NewLine + "Da li žeite završiti narudzbu?",
                                                                        Global.GetMessage("warning"), MessageBoxButtons.YesNo);
                                if (dialog == DialogResult.No)
                                    nastavi = false;
                            }
                        }
                    }
                }

            if (nastavi)
            {
                //IzlaziReport reportForm = new IzlaziReport(narudzba.NarudzbaID);
                //reportForm.Show();
                Izlazi izlaz = new Izlazi();

                izlaz.NarudzbaID = narudzba.NarudzbaID;
                izlaz.IznosSaPDV = (decimal)narudzba.Iznos;
                izlaz.IznosBezPDV =(decimal)narudzba.Iznos / (decimal)1.17;
                izlaz.SkladisteID = Convert.ToInt32(skladistaList.SelectedValue);
                izlaz.KorisnikID = Global.prijavljeniKorisnik.KorisnikID;
                //izlaz.Datum = DateTime.Now;
                //izlaz.BrojRacuna = "";
                HttpResponseMessage response15 = izlaziservice.PostActionResponse("ProcesirajNarudzbu", izlaz);

                if (response15.IsSuccessStatusCode)
                {
                    MessageBox.Show(Global.GetMessage("success"), Global.GetMessage("info"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                    this.Close();
                  
                    ActiveForm forma = new ActiveForm();
                    forma.Show();
                }
                else
                {
                    MessageBox.Show(Global.GetMessage("api_error"));
                }
            }

        }

        
    }
        private void skladistaList_Validating(object sender, CancelEventArgs e)
        {
            if (skladistaList.SelectedIndex <=0)
            {
                e.Cancel = true;

                errorProvider1.SetError(skladistaList, Global.GetMessage("required"));
            }
            else
            {
                errorProvider1.SetError(skladistaList, "");
            }
        }
    }
}

