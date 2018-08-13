using eProdaja_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eProdaja_API.Models;


namespace eProdaja_UI.Warehouse
{
    public partial class StateWarehouseForm : MetroFramework.Forms.MetroForm
    {
        private WebAPIHelper skladisteService = new WebAPIHelper("http://localhost:60271/", "api/Skladista");
        private WebAPIHelper proizvodiService = new WebAPIHelper("http://localhost:60271/", "api/Proizvodi");

        public StateWarehouseForm()
        {
            InitializeComponent();
        }

        private void StateWarehouseForm_Load(object sender, EventArgs e)
        {
            BindGridSkladista();
        }

        private void BindGridSkladista()
        {
            HttpResponseMessage response = skladisteService.getResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Skladista> skladista = response.Content.ReadAsAsync<List<Skladista>>().Result;
                skladista.Insert(0, new Skladista());
                skladistechb.DataSource = skladista;
                skladistechb.ValueMember = "SkladisteID";
                skladistechb.DisplayMember = "Naziv";
            }
        }

        private void skladistechb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skladistechb.SelectedValue != null && skladistechb.SelectedIndex != 0)
            {
                int skladisteID = Convert.ToInt32(skladistechb.SelectedValue);
                if (skladisteID > 0)
                {
                    HttpResponseMessage response =
                        proizvodiService.getActionResponse("GetProzivodBySkladiste", skladisteID.ToString());
                    if (response.IsSuccessStatusCode)
                    {
                        proizvodidgv.AutoGenerateColumns = false;
                        proizvodidgv.DataSource =
                            response.Content.ReadAsAsync<List<esp_Proizvodi_SelectBySkladiste_Result>>().Result;
                         
                    }
                    else
                        MessageBox.Show(Global.GetMessage("api_error"), Global.GetMessage("warning"));
                }
                else
                    MessageBox.Show(Global.GetMessage("item_sel_error"), Global.GetMessage("warning"));
            }
        }
    }
}
