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
    public partial class ProizvodiInfoForm : MetroFramework.Forms.MetroForm
    {

        private WebAPIHelper proizvodiService = new WebAPIHelper("http://localhost:60271/", "api/Proizvodi");

        private WebAPIHelper kategorijeService = new WebAPIHelper("http://localhost:60271/", "api/KategorijeProizvoda");

        

        public ProizvodiInfoForm()
        {
            InitializeComponent();
        }

        private void ProizvodiInfoForm_Load(object sender, EventArgs e)
        {
            BindAktivniProizvodi();
            BindKategorije();
        }

        private void BindKategorije()
        {
            HttpResponseMessage response = kategorijeService.getResponse();
            if (response.IsSuccessStatusCode)
            {
                List<KategorijeProizvoda> kategorija = response.Content.ReadAsAsync<List<KategorijeProizvoda>>().Result;
                kategorija.Insert(0, new KategorijeProizvoda());
                comboKategorija.DataSource = kategorija;
                comboKategorija.DisplayMember = "Naziv";
                comboKategorija.ValueMember = "KategorijaID";

            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
            }
        }

        private void BindAktivniProizvodi()
        {
            HttpResponseMessage response = proizvodiService.getResponse("GetAktivniProizvodi");
            if (response.IsSuccessStatusCode)
            {
                List<esp_Proizvodi_SelectAktivni_Result> proizvodi =
                    response.Content.ReadAsAsync<List<esp_Proizvodi_SelectAktivni_Result>>().Result;
                gridProizvodi.DataSource = proizvodi;


            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BindNeaktivni();
        }

        private void BindNeaktivni()
        {
            HttpResponseMessage response = proizvodiService.getResponse("GetNeaktivniProizvodi");
            if (response.IsSuccessStatusCode)
            {
                List<esp_Proizvodi_SelectNeAktivni_Result> proizvodi =
                    response.Content.ReadAsAsync<List<esp_Proizvodi_SelectNeAktivni_Result>>().Result;
                gridProizvodi.DataSource = proizvodi;


            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Products.AddForm form = new AddForm();
            form.Show();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            
            if (gridProizvodi.Rows.Count == 0)
            {
                MessageBox.Show(Global.GetMessage("item_select_err"), Global.GetMessage("warning"));
            }
            else
            {
                int proizvodid = Convert.ToInt32(gridProizvodi.SelectedRows[0].Cells[0].Value.ToString());
                if (proizvodid > 0)
                {
                    HttpResponseMessage response1 = proizvodiService.getActionResponse("GetProizvodStatus",
                       proizvodid.ToString());
                    bool status = response1.Content.ReadAsAsync<bool>().Result;
                    if (!status)
                    {
                        MessageBox.Show("Proizvod vec izbrisan!!");
                    }
                    else
                    {
                        
                   
                    HttpResponseMessage response = proizvodiService.DeleteResponse(proizvodid);
                 
                    if (response.IsSuccessStatusCode)
                    {
                            
                            MessageBox.Show(Global.GetMessage("item_del_succ"));
                        BindAktivniProizvodi();
                    
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

        private void button6_Click(object sender, EventArgs e)
        {
            BindAktivniProizvodi();
        }

        private void comboKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindCombo();

        }

        private void BindCombo()
        {
            HttpResponseMessage response = proizvodiService.getActionResponse("SearchProizvodiByVrsta", comboKategorija.SelectedValue.ToString());

            if (response.IsSuccessStatusCode)
            {
                gridProizvodi.DataSource = response.Content.ReadAsAsync<List<esp_Proizvodi_SelectByVrsta_Result>>().Result;
                //dataGridView1.Columns[0].Visible = false;

            }
        }

        private void btnPretragaPoSifri_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = proizvodiService.getActionResponse("GetProizvodiBySifra",
                textSifra.Text.Trim());
            if (response.IsSuccessStatusCode)
            {
                List<esp_Proizvodi_SelectBySifra_Result> proizvodi =
                    response.Content.ReadAsAsync<List<esp_Proizvodi_SelectBySifra_Result>>().Result;
                gridProizvodi.DataSource = proizvodi;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
            }
        }

        private void gridProizvodi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridProizvodi.Rows.Count == 0)
                MessageBox.Show(Global.GetMessage("item_select_err"));
            else
            {
                int proizvodID = Convert.ToInt32(gridProizvodi.SelectedRows[0].Cells[0].Value.ToString());
                if (proizvodID > 0)
                {
                    EditProductForm urediProizvodForm = new EditProductForm(proizvodID);
                    urediProizvodForm.Show();
                }
                else
                    MessageBox.Show(Global.GetMessage("item_select_err"));
            }

        }

        //private void gridProizvodi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{

        //    if (gridProizvodi.Rows.Count == 0)
        //        MessageBox.Show(Global.GetMessage("item_select_err"));
        //    else
        //    {
        //        int proizvodID = Convert.ToInt32(gridProizvodi.SelectedRows[0].Cells[0].Value.ToString());
        //        if (proizvodID > 0)
        //        {
        //            EditProductForm urediProizvodForm = new EditProductForm(proizvodID);
        //            urediProizvodForm.Show();
        //        }
        //        else
        //            MessageBox.Show(Global.GetMessage("item_select_err"));
        //    }
        //}
    }
}
