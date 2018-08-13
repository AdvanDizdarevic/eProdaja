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
using eProdaja_API.Models;


namespace eProdaja_UI.Novosti
{
    public partial class NovostiForm : MetroFramework.Forms.MetroForm
    {

        private WebAPIHelper  novostiService = new WebAPIHelper("http://localhost:60271/", "api/Novosti");
        public NovostiForm()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            HttpResponseMessage response = novostiService.getResponse();
            if (response.IsSuccessStatusCode)
            {
                dgvNovosti.AutoGenerateColumns = false;
                dgvNovosti.DataSource = response.Content.ReadAsAsync<List<eProdaja_API.Models.Novosti>>().Result;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
            }
        }

        private void NovostiForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnPrikaziUklonjene_Click(object sender, EventArgs e)
        {
            BindNeaktive();
        }

        private void BindNeaktive()
        {
            HttpResponseMessage response = novostiService.getActionResponse("GetNeaktivne");
            if (response.IsSuccessStatusCode)
            {
                dgvNovosti.AutoGenerateColumns = false;
                dgvNovosti.DataSource = response.Content.ReadAsAsync<List<eProdaja_API.Models.Novosti>>().Result;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
            }
        }

        private void brnDodaj_Click(object sender, EventArgs e)
        {
            NovostiAddForm dodajnovost = new NovostiAddForm();
            dodajnovost.Show();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int novostId = Convert.ToInt32(dgvNovosti.SelectedRows[0].Cells[0].Value.ToString());
            if (novostId > 0)
            {
                HttpResponseMessage response2 = novostiService.getActionResponse("GetNovostiStatus",
                    novostId.ToString());
                bool status = response2.Content.ReadAsAsync<bool>().Result;
                if (!status)
                {
                    MessageBox.Show("Novost vec izbrisan!!");
                }
                else
                {


                    HttpResponseMessage response = novostiService.getActionResponse(novostId.ToString());
                    if (response.IsSuccessStatusCode)
                    {
                        eProdaja_API.Models.Novosti novost =
                            response.Content.ReadAsAsync<eProdaja_API.Models.Novosti>().Result;
                        novost.Status = false;


                        HttpResponseMessage response1 = novostiService.putResponse(novostId, novost);
                        if (response1.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Novost uspjesno obrisana!");
                        }
                        BindGrid();
                    }
                    else
                        MessageBox.Show(Global.GetMessage("api_error"));
                }
            }
            else
                MessageBox.Show(Global.GetMessage("item_select_err"));
        }

 

        private void dgvNovosti_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNovosti.Rows.Count == 0)
                MessageBox.Show(Global.GetMessage("item_select_error"));
            else
            {
                int novostId = Convert.ToInt32(dgvNovosti.SelectedRows[0].Cells[0].Value.ToString());
                if (novostId > 0)
                {
                    NovostiEditForm urediNovostForm = new NovostiEditForm(novostId);
                    urediNovostForm.Show();
                }
                else
                    MessageBox.Show(Global.GetMessage("item_select_err"));
            }
        }
    }
    }

