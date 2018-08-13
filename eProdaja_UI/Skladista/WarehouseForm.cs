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

namespace eProdaja_UI.Warehouse
{
    public partial class WarehouseForm : MetroFramework.Forms.MetroForm
    {
        private WebAPIHelper skladisteService = new WebAPIHelper("http://localhost:60271/", "api/Skladista");

        public WarehouseForm()
        {
            InitializeComponent();
        }

        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            BindGridSkladistaAktivni();
        }

        private void BindGridSkladistaAktivni()
        {
            HttpResponseMessage response = skladisteService.getActionResponse("GetAktivni");
            if (response.IsSuccessStatusCode)
            {
                skladistedgw.AutoGenerateColumns = false;
                skladistedgw.DataSource = response.Content.ReadAsAsync<List<Skladista>>().Result;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"), Global.GetMessage("warning"));
            }
        }

        private void prikaziAktivnaSkladistabtn_Click(object sender, EventArgs e)
        {
            BindGridSkladistaAktivni();
        }

        private void prikaziNeAktivneSkladistebtn_Click(object sender, EventArgs e)
        {
            BindGridSkladistaNeAktivni();
        }

        private void BindGridSkladistaNeAktivni()
        {
            HttpResponseMessage response = skladisteService.getActionResponse("GetNeAktivni");
            if (response.IsSuccessStatusCode)
            {
                skladistedgw.AutoGenerateColumns = false;
                skladistedgw.DataSource = response.Content.ReadAsAsync<List<Skladista>>().Result;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"), Global.GetMessage("warning"));
            }
        }

        private void prikaziSvaSkladistabtn_Click(object sender, EventArgs e)
        {
            BindGridSkladistaSelectAll();
        }

        private void BindGridSkladistaSelectAll()
        {
            HttpResponseMessage response = skladisteService.getResponse();
            if (response.IsSuccessStatusCode)
            {
                skladistedgw.AutoGenerateColumns = false;
                skladistedgw.DataSource = response.Content.ReadAsAsync<List<Skladista>>().Result;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"), Global.GetMessage("warning"));
            }
        }

        private void ocistiOpisbtn_Click(object sender, EventArgs e)
        {
            opistxt.Text = "";
        }

        private void izbrisSkladistebtn_Click(object sender, EventArgs e)
        {
            if (skladistedgw.Rows.Count == 0)
                MessageBox.Show(Global.GetMessage("item_sel_error"));
            else
            {
                int skladisteID = Convert.ToInt32(skladistedgw.SelectedRows[0].Cells[0].Value.ToString());
                if (skladisteID > 0)
                {
                    if (!CheckIfDeleted(skladisteID))
                    {
                        HttpResponseMessage
                            response = skladisteService.DeleteResponse(skladisteID);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show(Global.GetMessage("skladiste_del_succ"), Global.GetMessage("info"));
                            BindGridSkladistaAktivni();
                        }
                        else
                            MessageBox.Show(
                                Global.GetMessage("api_error"), Global.GetMessage("warning"));
                    }
                    else
                        MessageBox.Show("Skladiste je vec izbrisano!");
                }
                else
                    MessageBox.Show(Global.GetMessage("item_error"), Global.GetMessage("warning"));
            }
        }

        private bool CheckIfDeleted(int skaldisteId){
            HttpResponseMessage response = skladisteService.getActionResponse("GetNeAktivni");
            if (response.IsSuccessStatusCode)
            {
                List<Skladista> skladiste = response.Content.ReadAsAsync<List<Skladista>>().Result;
                foreach (Skladista s in skladiste)
                {
                    if (s.SkladisteID == skaldisteId)
                        return true;
                }
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"), Global.GetMessage("warning"));
            }
            return false;
        }
       

        private void pretragabtn_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = skladisteService.getActionResponse("GetSearch",
                pretragaSkladistetxt.Text.Trim());
            if (response.IsSuccessStatusCode)
            {
                skladistedgw.AutoGenerateColumns = false;
                skladistedgw.DataSource = response.Content.ReadAsAsync<List<Skladista>>().Result;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"), Global.GetMessage("warning"));
            }
        }

        private void dodajSkladistebtn_Click(object sender, EventArgs e)
        {
            AddWarehouseForm dodajSkladisteForm = new AddWarehouseForm();
            dodajSkladisteForm.Show();
        }

        private void urediSkladistebtn_Click(object sender, EventArgs e)
        {
            if (skladistedgw.Rows.Count == 0)
                MessageBox.Show(Global.GetMessage("item_sel_err"), Global.GetMessage("warning"));
            else
            {
                int skladisteId = Convert.ToInt32(skladistedgw.SelectedRows[0].Cells[0].Value.ToString());
                if (skladisteId > 0)
                {
                    EditWarehouseForm urediSkladisteForm = new EditWarehouseForm(skladisteId);
                    urediSkladisteForm.Show();
                }
                else
                {
                    MessageBox.Show(Global.GetMessage("item_sel_err"), Global.GetMessage("warning"));
                }   
            }
        }

        private void skladistedgw_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int dobavljacID = Convert.ToInt32(skladistedgw.SelectedRows[0].Cells[0].Value.ToString());
            if (dobavljacID > 0)
            {
                HttpResponseMessage response = skladisteService.getActionResponse(dobavljacID.ToString());
                if (response.IsSuccessStatusCode)
                {
                    Skladista skladiste = response.Content.ReadAsAsync<Skladista>().Result;
                    opistxt.Text = skladiste.Naziv + " : " + skladiste.Opis;
                }
                else
                    opistxt.Text = Global.GetMessage("api_error");
            }
        }
    }
}
