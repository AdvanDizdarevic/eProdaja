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
using eProdaja_UI;
using eProdaja_UI.Util;

namespace eProdaja_UI.Warehouse
{
    public partial class EditWarehouseForm : MetroFramework.Forms.MetroForm
    {
        private WebAPIHelper skladisteService = new WebAPIHelper("http://localhost:60271/", "api/Skladista");
        private int skladisteID = 0;
        private Skladista skladiste { get; set; }
        public EditWarehouseForm(int skladisteid)
        {
            InitializeComponent();
            skladisteID = skladisteid;
        }

        private void EditWarehouseForm_Load(object sender, EventArgs e)
        {
            GetSkladiste();
            LoadPodatke();
        }

        private void LoadPodatke()
        {
            nazivSkladistatxt.Text = skladiste.Naziv;
            adresaSkladistatxt.Text = skladiste.Adresa;
            opisSkladistatxt.Text = skladiste.Opis;
            statusSkladistachb.Checked = skladiste.Status;
        }

        private void GetSkladiste()
        {
            if (skladisteID > 0)
            {
                HttpResponseMessage response = skladisteService.getActionResponse(skladisteID.ToString());
                if (response.IsSuccessStatusCode)
                {
                    skladiste = response.Content.ReadAsAsync<Skladista>().Result;
                }
                else
                {
                    MessageBox.Show(Global.GetMessage("api_error"), Global.GetMessage("warning"));
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"), Global.GetMessage("warning"));
                this.Close();
            }
        }

        private void spasiPromjenebtn_Click(object sender, EventArgs e)
        {
            PreuzmiPodatke();
            HttpResponseMessage response = skladisteService.putResponse(skladiste.SkladisteID,skladiste);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(Global.GetMessage("success"), Global.GetMessage("info"));
                this.Close();
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"), Global.GetMessage("warning"));
            }
        }

        private void PreuzmiPodatke()
        {
            skladiste.Naziv = nazivSkladistatxt.Text;
            skladiste.Adresa = adresaSkladistatxt.Text;
            skladiste.Opis = opisSkladistatxt.Text;
            skladiste.Status = statusSkladistachb.Checked;
        }
        #region Validation
        private void nazivSkladistatxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(nazivSkladistatxt.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(nazivSkladistatxt, Global.GetMessage("required"));
            }
            else
                errorProvider.SetError(nazivSkladistatxt, "");
        }

        private void adresaSkladistatxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(adresaSkladistatxt.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(adresaSkladistatxt, Global.GetMessage("required"));
            }
            else
                errorProvider.SetError(adresaSkladistatxt, "");
        }
        private void opisSkladistatxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(opisSkladistatxt.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(opisSkladistatxt, Global.GetMessage("required"));
            }
            else
                errorProvider.SetError(opisSkladistatxt, "");
        }
        #endregion
    }
}
