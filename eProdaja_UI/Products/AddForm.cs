using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eProdaja_API.Models;
using eProdaja_UI.Util;
using System.Net.Http;
using System.IO;
using System.Configuration;

namespace eProdaja_UI.Products
{
    public partial class AddForm : Form
    {
        WebAPIHelper vrstaService = new WebAPIHelper("http://localhost:60271/", "api/KategorijeProizvoda");
        WebAPIHelper jedinicaService = new WebAPIHelper("http://localhost:60271/", "api/JediniceMjere");
        WebAPIHelper proizvodiService = new WebAPIHelper("http://localhost:60271/", "api/Proizvodi");

        private Proizvodi proizvod { get; set; }

        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            BindVrstaProizvoda();
            BindJediniceMjere();
           // HttpResponseMessage response = proizvodiService.getResponse();
           //dataGridView1.DataSource = response.Content.ReadAsAsync<List<Proizvodi>>().Result;


        }

        private void BindJediniceMjere()
        {
            HttpResponseMessage response = jedinicaService.getResponse();
            if (response.IsSuccessStatusCode)
            {
                List<JediniceMjere> jedinice = response.Content.ReadAsAsync<List<JediniceMjere>>().Result;
                jedinice.Insert(0, new JediniceMjere());
                comboJedinica.DataSource = jedinice;
                comboJedinica.DisplayMember = "Naziv";
                comboJedinica.ValueMember = "JedinicaMjereID";
            }
        }

        private void BindVrstaProizvoda()   
        {
            HttpResponseMessage response = vrstaService.getResponse();
            if (response.IsSuccessStatusCode)
            {
                List<KategorijeProizvoda> kategorija = response.Content.ReadAsAsync<List<KategorijeProizvoda>>().Result;
                kategorija.Insert(0, new KategorijeProizvoda());
                comboVrsta.DataSource = kategorija;
                comboVrsta.DisplayMember = "Naziv";
                comboVrsta.ValueMember = "KategorijaID";
      
            }
        }

        private void btnSlika_Click(object sender, EventArgs e)
        {
            try
            {
                if (proizvod == null)
                    proizvod = new Proizvodi();
                openFileDialog1.ShowDialog();
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
                    pictureBox.Image = resizedImage;

                    Image croppedImage = resizedImage;

                    int croppedXPosition = (resizedImage.Width - croppedImgWidth) / 2;
                    int croppedYPosition = (resizedImage.Height - croppedImgHeight) / 2;

                    if (resizedImage.Width >= croppedImgWidth && resizedImage.Height >= croppedImgHeight)
                    {

                        croppedImage = UIHelper.CropImage(resizedImage, new Rectangle(croppedXPosition, croppedYPosition, croppedImgWidth, croppedImgHeight));
                        ms = new MemoryStream();
                        croppedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        proizvod.SlikaThumb = ms.ToArray();

                        pictureBox.Image = croppedImage;
                    }

                }
            }
            catch (Exception)
            {

                proizvod = null;
                pictureBox.Image = null;
                txtSlika.Text = "";
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            if (proizvod == null)
                proizvod = new Proizvodi();

            if(comboVrsta.SelectedIndex!=0)
            proizvod.KategorijaID = Convert.ToInt32(comboVrsta.SelectedValue);

            proizvod.Sifra = txtSifra.Text;
            proizvod.Naziv = txtNaziv.Text;
            proizvod.Cijena = Convert.ToDecimal(txtCijena.Text);

            if (comboJedinica.SelectedIndex != 0)
                proizvod.JedinicaMjereID = Convert.ToInt32(comboJedinica.SelectedValue);
            proizvod.Status = true;

            HttpResponseMessage response;

            if (proizvod.ProizvodID == 0)
                response = proizvodiService.postResponse(proizvod);
            else
                response = proizvodiService.putResponse(proizvod.ProizvodID, proizvod);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(Global.GetMessage("product_succ"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else
            {
                MessageBox.Show(response.ReasonPhrase, Global.GetMessage("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BindGrid();
            Clear();

        }

        private void BindGrid()
        {
            HttpResponseMessage response = proizvodiService.getActionResponse("SearchProizvodiByVrsta", comboVrsta.SelectedValue.ToString());

            if (response.IsSuccessStatusCode)
            {
                dataGridView1.DataSource = response.Content.ReadAsAsync<List<esp_Proizvodi_SelectByVrsta_Result>>().Result;
                //dataGridView1.Columns[0].Visible = false;

            }
        }

        private void Clear()
        {
            proizvod = null;
            txtSifra.Text = "";
            txtNaziv.Text = "";
            txtCijena.Text = "";
            comboJedinica.SelectedIndex = 0;
            txtSlika.Text = "";
            pictureBox.Image = null;
        }


        private void LoadData()
        {
            comboVrsta.SelectedValue = proizvod.KategorijaID;
            txtSifra.Text = proizvod.Sifra;
            txtNaziv.Text = proizvod.Naziv;
            txtCijena.Text = proizvod.Cijena.ToString();
            comboJedinica.SelectedValue = proizvod.JedinicaMjereID;

            var ms = new MemoryStream(proizvod.SlikaThumb);
            Image croppedImage = Image.FromStream(ms);

            pictureBox.Image = croppedImage;
        }

        private void comboVrsta_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
            if (proizvod != null)
                Clear();
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
            string proizvodID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            HttpResponseMessage response = proizvodiService.getResponse(proizvodID);
            if (response.IsSuccessStatusCode)
            {
                proizvod = response.Content.ReadAsAsync<Proizvodi>().Result;
                LoadData();
            }
        }
    }
}