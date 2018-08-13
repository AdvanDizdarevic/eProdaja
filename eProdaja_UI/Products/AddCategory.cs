using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eProdaja_API.Models;
using eProdaja_PCL.Util;
using WebAPIHelper = eProdaja_UI.Util.WebAPIHelper;

namespace eProdaja_UI.Products
{
    public partial class AddCategory : MetroFramework.Forms.MetroForm
    {

        WebAPIHelper vrstaService = new WebAPIHelper("http://localhost:60271/", "api/KategorijeProizvoda");
        public AddCategory()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                KategorijeProizvoda kategorija = new KategorijeProizvoda();
                kategorija.Naziv = txtNazivkKategorije.Text;
                kategorija.Status = chkAktivna.Checked;

                HttpResponseMessage response = vrstaService.postResponse(kategorija);
                if (response.IsSuccessStatusCode)
                {
                    DialogResult dialogResult = MessageBox.Show(Global.GetMessage("cat_succ"), Global.GetMessage("info"),
                        MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                        ClearInput();
                    else
                        this.Close();
                }
                else
                {
                    MessageBox.Show(Global.GetMessage("api_error"));
                }
            }

        }

        private void ClearInput()
        {
            txtNazivkKategorije.Text = "";
            chkAktivna.Checked = false;
        }
        #region Validacija

        private void txtNazivkKategorije_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNazivkKategorije.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNazivkKategorije, Global.GetMessage("cat_name_req"));
            }
            else
            {
                errorProvider.SetError(txtNazivkKategorije,"");
            }
        }
        #endregion

        private void AddCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
