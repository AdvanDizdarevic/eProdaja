using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using eProdaja_API.Models;
using eProdaja_UI;
using eProdaja_UI.Util;


namespace eProdaja_UI.AkcijskiProizvodi
{
    public partial class AddProductOnAction : MetroFramework.Forms.MetroForm
    {
        private WebAPIHelper proizvodiService = new WebAPIHelper("http://localhost:60271/", "api/Proizvodi");
        private WebAPIHelper akcijskiProizvodiService = new WebAPIHelper("http://localhost:60271/", "api/AkcijskiProizvodi");

        private List<eProdaja_API.Models.AkcijskiProizvodi> akcijskiProizvodi { get; set; } 
        private List<eProdaja_API.Models.AkcijskiProizvodi> getakcijskiProizvodi { get; set; } 
        private List<Proizvodi> proizvodi { get; set; }
        private List<esp_Proizvodi_SelectAktivni_Result> aktivniProizvodi { get; set; } 
        private decimal popust { get; set; }
        private DateTime datum { get; set; }

        public AddProductOnAction()
        {
            InitializeComponent();
            BindGetAkcijskiProizvodi();
            akcijskiProizvodi = new List<eProdaja_API.Models.AkcijskiProizvodi>();
            proizvodi = new List<Proizvodi>();
        }

        private void BindGetAkcijskiProizvodi()
        {
            HttpResponseMessage response = akcijskiProizvodiService.getActionResponse("GetTrenutnoAktivni");
            if (response.IsSuccessStatusCode)
            {
                getakcijskiProizvodi = response.Content.ReadAsAsync<List<eProdaja_API.Models.AkcijskiProizvodi>>().Result;
            }
            else
                MessageBox.Show(Global.GetMessage("api_error"));
        }

        private void AddProductOnAction_Load(object sender, EventArgs e)
        {
            BindProizvodi();
        }

        private void BindProizvodi()
        {
            HttpResponseMessage response = proizvodiService.getActionResponse("GetAktivniProizvodi");
            if (response.IsSuccessStatusCode)
            {
                aktivniProizvodi = response.Content.ReadAsAsync<List<esp_Proizvodi_SelectAktivni_Result>>().Result;
                proizvodiDgv.AutoGenerateColumns = false;
                proizvodiDgv.ClearSelection();
                proizvodiDgv.DataSource = aktivniProizvodi;
                

                proizvodi = new List<Proizvodi>();
            }
            else
                MessageBox.Show(Global.GetMessage("api_error"));
        }

        private void dodajOdabraniProizvodBtn_Click(object sender, EventArgs e)
        {
            int proizvodID = Convert.ToInt32(proizvodiDgv.SelectedRows[0].Cells[0].Value.ToString());

            if (proizvodID > 0)
            {
                AddProductOnActionDetails details = new AddProductOnActionDetails(proizvodID);
                
                details.ShowDialog();
                
                datum = details.datum;
                popust = details.popust;

                if (DodajAkcijskiProizvod(proizvodID))
                {
                    proizvodi.Add(details.proizvod);
                    BindAkcijskiProizvodi();
                }
                else
                    MessageBox.Show(Global.GetMessage("item_exist"));
            }
            else
                MessageBox.Show(Global.GetMessage("item_sel_err"));
        }

        private bool DodajAkcijskiProizvod(int proizvodId)
        {
            eProdaja_API.Models.AkcijskiProizvodi akcijskiProizvod = new eProdaja_API.Models.AkcijskiProizvodi();

            akcijskiProizvod.DatumPocetka = DateTime.Now;
            akcijskiProizvod.DatumKraja = datum;
            akcijskiProizvod.KorisnikID = Global.prijavljeniKorisnik.KorisnikID;
            akcijskiProizvod.ProizvodID = proizvodId;
            akcijskiProizvod.Status = true;
            akcijskiProizvod.Popust = popust;

            if (
                getakcijskiProizvodi.Where(x => (x.ProizvodID == akcijskiProizvod.ProizvodID) && (x.Status != false))
                    .FirstOrDefault() != null)
                return false;
            else
            {
                akcijskiProizvodi.Add(akcijskiProizvod);
                return true;
            }
        }


        private void BindAkcijskiProizvodi()
        {
            

            akcijskiProizvodiDgv.DataSource = null;
            akcijskiProizvodiDgv.Update();
            akcijskiProizvodiDgv.Refresh();

            akcijskiProizvodiDgv.AutoGenerateColumns = false;
            akcijskiProizvodiDgv.DataSource = proizvodi;
        }

        private void pohraniProizvodeBtn_Click(object sender, EventArgs e)
        {
            eProdaja_API.Models.AkcijskiProizvodi akcijskiProizvod = new eProdaja_API.Models.AkcijskiProizvodi();
            bool exit = true;
            foreach (eProdaja_API.Models.AkcijskiProizvodi p in akcijskiProizvodi)
            {

                HttpResponseMessage response = akcijskiProizvodiService.postResponse(p);
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Global.GetMessage("api_error"));
                    break;
                    exit = false;
                }
                
            }
            if (exit)
                this.Close();

        }

    }
}
