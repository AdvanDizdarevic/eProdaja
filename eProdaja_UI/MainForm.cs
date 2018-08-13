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
using eProdaja_UI.Buyes;
using eProdaja_UI.Novosti;
using eProdaja_UI.Products;
using eProdaja_UI.Supliers;
using eProdaja_UI.Util;
using eProdaja_UI.Warehouse;
using eProdaja_UI.AkcijskiProizvodi;
using eProdaja_UI.Izvjestaji;

namespace eProdaja_UI
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    { 

        WebAPIHelper narudzbaService = new WebAPIHelper("http://localhost:60271","api/Narudzbe");
        public MainForm()
        {
            InitializeComponent();
        }

        private void infoKorisniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users.InfoForm infoForm = new Users.InfoForm();
            infoForm.MdiParent = this;
            infoForm.Show();
        }


        private void infoProizvodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products.PurchaseForm nabavkaProizvoda = new Products.PurchaseForm();
            nabavkaProizvoda.MdiParent = this;
            nabavkaProizvoda.Show();
        }

        private void noviProizvodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products.AddForm dodavanjeProizvoda = new Products.AddForm();
            dodavanjeProizvoda.MdiParent = this;
            dodavanjeProizvoda.Show();
        }

        private void aktivneNarudzbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders.ActiveForm aktivneNarudzbe = new Orders.ActiveForm();
            aktivneNarudzbe.MdiParent = this;
            aktivneNarudzbe.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = narudzbaService.getActionResponse("GetBrojAktivnihNarudzbi");
            if (response.IsSuccessStatusCode)
            {
                int brojnarudzbi = response.Content.ReadAsAsync<int>().Result;
                if (brojnarudzbi > 0)
                {
                    notifyIcon.ShowBalloonTip(5000,"Nove narudzbe","Broj narudzbi: "+ brojnarudzbi,ToolTipIcon.Info);
                }
            }
        }

        private void infoProizvodiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Products.ProizvodiInfoForm dodavanjeProizvoda = new Products.ProizvodiInfoForm();
            dodavanjeProizvoda.MdiParent = this;
            dodavanjeProizvoda.Show();
        }

        private void kategorijeProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategorijesInfo kategorijeProzivoda = new CategorijesInfo();
            kategorijeProzivoda.MdiParent = this;
            kategorijeProzivoda.Show();
        }

        private void novostiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NovostiForm novosti = new NovostiForm();
            novosti.MdiParent = this;
            novosti.Show();
        }

        private void infoKupciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KupciForm kupci = new KupciForm();
            kupci.MdiParent = this;
            kupci.Show();
        }

        private void dobavljaciInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupliersForm dobavljaci = new SupliersForm();
            dobavljaci.MdiParent = this;
            dobavljaci.Show();
        }

        private void infoSkladistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WarehouseForm dobavljaci = new WarehouseForm();
            dobavljaci.MdiParent = this;
            dobavljaci.Show();
        }

        private void stanjeSkladistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StateWarehouseForm dobavljaci = new StateWarehouseForm();
            dobavljaci.MdiParent = this;
            dobavljaci.Show();
        }

        private void infoAkcijskiProizvodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductActionForm dobavljaci = new ProductActionForm();
            dobavljaci.MdiParent = this;
            dobavljaci.Show();
        }

  

        private void izlaziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IzlaziIzSkladista ulazi = new IzlaziIzSkladista();
            ulazi.MdiParent = this;
            ulazi.Show();
        }

        private void ulazniRacuniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UlaziUSkladiste ulazi = new UlaziUSkladiste();
            ulazi.MdiParent = this;
            ulazi.Show();
        }
    }
}
