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
using eProdaja_UI.Util;

namespace eProdaja_UI.Novosti
{
    public partial class NovostiAddForm : MetroFramework.Forms.MetroForm
    {

        private WebAPIHelper novostiService = new WebAPIHelper("http://localhost:60271/", "api/Novosti");
        private eProdaja_API.Models.Novosti novost = new eProdaja_API.Models.Novosti();

        public NovostiAddForm()
        {
            InitializeComponent();
        }

        private void NovostiAddForm_Load(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
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

        private void btnSacuvajNovosti_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren())
            {

                novost.KorisnikID = Global.prijavljeniKorisnik.KorisnikID;
                novost.Naziv = txtNaziv.Text;
                novost.Sadrzaj = txtSadrzaj.Text;
                novost.Datum = System.DateTime.Now;
                novost.Status = chkStatus.Checked;

                HttpResponseMessage response = novostiService.postResponse(novost);
                if (response.IsSuccessStatusCode)
                {
                    string poruka = "Novost uspješno dodana!" + Environment.NewLine +
                                    "Da li želite dodati novu novost?";
                    string captio = "Pitanje";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult dialogResult;

                    dialogResult = MessageBox.Show(poruka, captio, buttons);

                    if (dialogResult == DialogResult.Yes)
                        ClearInputData();
                    else
                        this.Close();
                }
                else
                {
                    MessageBox.Show(Global.GetMessage("api_error"));
                }
            }
        }

        private void ClearInputData()
        {
            txtNaziv.Text = "";
            txtSadrzaj.Text = "";
            chkStatus.Checked = false;
            textBox3.Text = "";
            slikabox.Image = null;
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
