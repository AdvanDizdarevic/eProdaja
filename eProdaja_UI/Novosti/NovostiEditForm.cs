using eProdaja_UI.Util;
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

namespace eProdaja_UI.Novosti
{
    public partial class NovostiEditForm : MetroFramework.Forms.MetroForm
    {
        private WebAPIHelper novostiService = new WebAPIHelper("http://localhost:60271/", "api/Novosti");
        private eProdaja_API.Models.Novosti novost;
        private int novostID;

        public NovostiEditForm(int id)
        {
            InitializeComponent();
            novostID = id;
        }

        private void NovostiEditForm_Load(object sender, EventArgs e)
        {
            BindPodaci();
        }

        private void BindPodaci()
        {
            HttpResponseMessage response = novostiService.getActionResponse(novostID.ToString());
            if (response.IsSuccessStatusCode)
            {
                novost = response.Content.ReadAsAsync<eProdaja_API.Models.Novosti>().Result;
                txtNaziv.Text = novost.Naziv;
                txtSadrzaj.Text = novost.Sadrzaj;
                chkStatus.Checked = novost.Status;
                if (novost.Slika == null)
                {
                    slikabox.ImageLocation = "eProdaja_UI/Slike/P54_DijagramKlasa.png";

                }
                else
                {
                    MemoryStream stream = new MemoryStream(novost.Slika);
                    Image getImage = Image.FromStream(stream);
                    slikabox.Image = getImage;
                }

            }
            else
            {
                MessageBox.Show(Global.GetMessage("api_error"));
                this.Close();
            }
        }

        private void btnSacuvajNovosti_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                novost.KorisnikID = Global.prijavljeniKorisnik.KorisnikID;
                novost.Naziv = txtNaziv.Text;
                novost.Sadrzaj = txtSadrzaj.Text;
                novost.Datum = System.DateTime.Now;
                novost.Status = chkStatus.Checked;

                HttpResponseMessage response = novostiService.putResponse(novostID, novost);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Global.GetMessage("success"));
                    this.Close();
                }
                else
                    MessageBox.Show(Global.GetMessage("api_error"));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox3.Text = openFileDialog1.FileName;

            Image image = Image.FromFile(textBox3.Text);

            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            novost.Slika = ms.ToArray();

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
                    novost.Slika = ms.ToArray();

                    slikabox.Image = resizedImage;
                }
                else
                {
                    MessageBox.Show(Global.GetMessage("img_crop_err"));
                }
            }
            else
            {
                MessageBox.Show(Global.GetMessage("img_size_err"));
            }
        }
        #region Validacija

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNaziv.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNaziv, Global.GetMessage("required"));
            }
            else
                errorProvider1.SetError(txtNaziv, "");
        }


        private void txtSadrzaj_Validating_1(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtSadrzaj.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSadrzaj, Global.GetMessage("required"));
            }
            else
                errorProvider1.SetError(txtSadrzaj, "");

        }

        #endregion
    }
}

