using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using eProdaja_PCL.Model;
using eProdaja_PCL.Util;
using eProdaja_UI.Model;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace eProdaja_Mob.Products
{

   
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DiscountProdDetail : Page
    {

        WebAPIHelper proizvodiService = new WebAPIHelper("http://localhost:60271/", "api/Proizvodi");
        private Proizvodi proizvod { get; set; }
        private decimal popust = 0;
        public DiscountProdDetail()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            List<string> myList = e.Parameter as List<string>;

            HttpResponseMessage response = proizvodiService.getActionResponse(myList[0]);

            if (response.IsSuccessStatusCode)
            {
                popust = Convert.ToDecimal(myList[1]);
                proizvod = response.Content.ReadAsAsync<Proizvodi>().Result;

                vrstaLabel.Text = proizvod.Kategorija;
                nazivLabel.Text = proizvod.Naziv;
                sifraLabel.Text = proizvod.Sifra;
                cijenaLabel.Text = (Math.Round(proizvod.Cijena - proizvod.Cijena * popust,2)  ).ToString() + " KM";

                MemoryStream ms = new MemoryStream(proizvod.SlikaThumb);
                BitmapImage image = new BitmapImage();

                await image.SetSourceAsync(ms.AsRandomAccessStream());

                proizvodImage.Source = image;

                if (Global.prijavljeniKupac != null)
                {
                 
                    kolicina.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    kolicinaInput.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    kupiButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                }

            }
    }
        private async void kupiButton_Click(object sender, RoutedEventArgs e)
        {
            if (Global.aktivnaNarudzba == null)
            {
                Global.aktivnaNarudzba = new Narudzbe();
                Global.aktivnaNarudzba.BrojNarudzbe = "1/" + DateTime.Now.Day + "-" + DateTime.Now.Year;
                Global.aktivnaNarudzba.Datum = DateTime.Now;
                Global.aktivnaNarudzba.KupacID = Global.prijavljeniKupac.KupacID;

            }
            bool proizvodPostoji = false;
            foreach (NarudzbaStavke item in Global.aktivnaNarudzba.NarudzbaStavkes)
            {
                if (proizvod.ProizvodID == item.ProizvodID)
                {
                    item.Kolicina += Convert.ToInt32(kolicinaInput.Value);
                    proizvodPostoji = true;
                    break;
                }
            }
            string message = "Uspjesno ste dodali proizvod u korpu!";
            if (proizvodPostoji)
                message = "Uspjesno ste izmjenili kolicinu proizvoda! ";
            else
            {
                NarudzbaStavke s = new NarudzbaStavke();
                s.ProizvodID = proizvod.ProizvodID;
                s.Proizvodi = proizvod;
                s.Proizvodi.Cijena =(short)(s.Proizvodi.Cijena - s.Proizvodi.Cijena * popust);
                s.Kolicina = Convert.ToInt32(kolicinaInput.Value);
                Global.aktivnaNarudzba.NarudzbaStavkes.Add(s);
            }
            MessageDialog msg = new MessageDialog(message);
            await msg.ShowAsync();
            NarudzbaInfoLabel.Text = "Broj naručenih proizvoda: " + Global.aktivnaNarudzba.NarudzbaStavkes.Count();
            zakljuciButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }

        private void zakljuciButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Profil.ActiveOrders));
        }

        private void KolicinaInput_OnValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            string msg = String.Format("{0}", e.NewValue);
            if (kolicina == null)
            {
                kolicina = new TextBox();
            
          
        }
            kolicina.Text = msg;
    }
    }
}
