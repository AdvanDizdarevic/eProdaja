using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eProdaja_API.Models;
using eProdaja_UI.Util;


namespace eProdaja_UI.Products
{
    public partial class EditProductForm : MetroFramework.Forms.MetroForm
    {

        WebAPIHelper vrstaService = new WebAPIHelper("http://localhost:60271/", "api/KategorijeProizvoda");
        WebAPIHelper jedinicaService = new WebAPIHelper("http://localhost:60271/", "api/JediniceMjere");
        WebAPIHelper proizvodiService = new WebAPIHelper("http://localhost:60271/", "api/Proizvodi");
        private Proizvodi proizvod { get; set; }
        private int proizvodID { get; set; }

        public EditProductForm(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            proizvodID = id;
            Proizvodi p = GetProizvod();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                proizvod.KategorijaID = Convert.ToInt32(comboVrsta.SelectedValue);
                proizvod.Sifra = txtSifra.Text;
                proizvod.Naziv = txtNaziv.Text;
                txtCijena.Text = string.Format("{0:#,##0.00}", double.Parse(txtCijena.Text));
                proizvod.Cijena = Convert.ToDecimal(txtCijena.Text);
                proizvod.JedinicaMjereID = Convert.ToInt32(comboJedinica.SelectedValue);
                proizvod.Status = checkBox1.Checked;

                HttpResponseMessage response = proizvodiService.putResponse(proizvodID, proizvod);

                if (response.IsSuccessStatusCode)
                {

                    MessageBox.Show(Global.GetMessage("success"));
                    this.Close();
                }
                else
                    MessageBox.Show(Global.GetMessage("api_error"));
            }
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            proizvod = GetProizvod();
            BindKategorijeProizvoda();
            BindJediniceProizvoda();
            txtSifra.Text = proizvod.Sifra;
            txtCijena.Text = proizvod.Cijena.ToString();
            MemoryStream stream = new MemoryStream(proizvod.SlikaThumb);
            Image getImage = Image.FromStream(stream);
            pictureBox.Image = getImage;
            txtNaziv.Text = proizvod.Naziv;
            checkBox1.Checked = proizvod.Status;
        }

        private void BindJediniceProizvoda()
        {
            HttpResponseMessage response = vrstaService.getResponse();

            if (response.IsSuccessStatusCode)
            {
                List<KategorijeProizvoda> vrsteProizvoda =
                    response.Content.ReadAsAsync<List<KategorijeProizvoda>>().Result;
                vrsteProizvoda.Insert(0, new KategorijeProizvoda());
                comboVrsta.DataSource = vrsteProizvoda;
                comboVrsta.DisplayMember = "Naziv";
                comboVrsta.ValueMember = "KategorijaID";
                comboVrsta.SelectedValue = proizvod.KategorijaID;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
            }
        }

        private void BindKategorijeProizvoda()
        {
            HttpResponseMessage response = jedinicaService.getResponse();

            if (response.IsSuccessStatusCode)
            {
                List<JediniceMjere> jediniceMjere = response.Content.ReadAsAsync<List<JediniceMjere>>().Result;
                jediniceMjere.Insert(0, new JediniceMjere());
                comboJedinica.DataSource = jediniceMjere;
                comboJedinica.DisplayMember = "Naziv";
                comboJedinica.ValueMember = "JedinicaMjereID";
                comboJedinica.SelectedValue = proizvod.JedinicaMjereID;
            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
            }
        }

        private Proizvodi GetProizvod()
        {
            HttpResponseMessage response = proizvodiService.getActionResponse(proizvodID.ToString());
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<Proizvodi>().Result;
            }
            else
                return null;
        }

        private void btnSlika_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                txtSlika.Text = openFileDialog1.FileName;

                Image image = Image.FromFile(txtSlika.Text);

                MemoryStream ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                proizvod.Slika = ms.ToArray();

                int resizedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgWidth"]);
                int resizedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgHeight"]);
                int croppedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgWidth"]);
                int croppedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgHeight"]);

                if (image.Width > resizedImgWidth)
                {
                    Image resizedImage = UIHelper.ResizeImage(image, new Size(resizedImgWidth, resizedImgHeight));

                    Image croppedImage = resizedImage;

                    int croppedXPosition = (resizedImage.Width - croppedImgWidth) / 2;
                    int croppedYPosition = (resizedImage.Height - croppedImgHeight) / 2;

                    if (resizedImage.Width >= croppedImgWidth && resizedImage.Height >= croppedImgHeight)
                    {
                        croppedImage = UIHelper.CropImage(resizedImage,
                            new Rectangle(croppedXPosition, croppedYPosition, croppedImgWidth, croppedImgHeight));

                        ms = new MemoryStream();
                        croppedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        proizvod.SlikaThumb = ms.ToArray();

                        pictureBox.Image = resizedImage;
                    }
                    else
                    {
                        MessageBox.Show(Global.GetMessage("img_crop_err"));
                    }
                }
                else
                {
                    MessageBox.Show("img_size_err");
                }
            }
        }

        #region Validating
        private void sifraInputtxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtSifra.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtSifra, Global.GetMessage("required"));
            }
            else
                errorProvider.SetError(txtSifra, "");
        }

        private void nazivInputtxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNaziv.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaziv, Global.GetMessage("required"));
            }
            else
                errorProvider.SetError(txtNaziv, "");
        }

        private void cijenaInputtxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtCijena.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtCijena, Global.GetMessage("required"));
            }
            else
                errorProvider.SetError(txtCijena, "");
        }

        private void jedinicaMjereComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (comboJedinica.SelectedItem == null)
            {
                e.Cancel = true;
                errorProvider.SetError(comboJedinica, Global.GetMessage("required"));
            }
            else
                errorProvider.SetError(comboJedinica, "");
        }

        private void kategorijeProizvodacb_Validating(object sender, CancelEventArgs e)
        {
            if (comboVrsta.SelectedItem == null)
            {
                e.Cancel = true;
                errorProvider.SetError(comboVrsta, Global.GetMessage("required"));
            }
            else
                errorProvider.SetError(comboVrsta, "");
        }
        #endregion
    }
}
