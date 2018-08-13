using eProdaja_UI.Model;
using eProdaja_UI.Util;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace eProdaja_Mob.Products
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Details : Page
    {
        WebAPIHelper proizvodiService = new WebAPIHelper("http://localhost:60271/", "api/Proizvodi");
        WebAPIHelper preporukaService = new WebAPIHelper("http://localhost:60271/", "api/Preporuka");
        public Proizvodi proizvod { get; set; }

        public Details()
        {
            this.InitializeComponent();
            preporuceniProizovidHeader.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            List<string> myList = e.Parameter as List<string>;

            HttpResponseMessage response = proizvodiService.getResponse(myList[0].ToString());

            if (response.IsSuccessStatusCode)
            {
               proizvod = response.Content.ReadAsAsync<Proizvodi>().Result;

                vrstaLabel.Text = proizvod.Kategorija;
                nazivLabel.Text = proizvod.Naziv;
                sifraLabel.Text = proizvod.Sifra;
                cijenaLabel.Text = proizvod.Cijena.ToString() + " KM";

              

                MemoryStream ms = new MemoryStream(proizvod.SlikaThumb);
                BitmapImage image = new BitmapImage();

                await image.SetSourceAsync(ms.AsRandomAccessStream());

                proizvodImage.Source = image;
                if (Global.prijavljeniKupac != null)
                {
                    kolicina.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    kolicinaInput.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    kupiButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    preporuceniProizovidHeader.Visibility = Visibility.Visible;
                    proizvodiList.Visibility = Visibility.Visible;
                }
                HttpResponseMessage response1 = preporukaService.getActionResponse("GetSlicneProizvode",
                    myList[0]);
                if (response1.IsSuccessStatusCode)
                {
                    proizvodiList.ItemsSource = response1.Content.ReadAsAsync<List<Proizvodi>>().Result;
                }

            }
        }

        private async void kupiButton_Click(object sender, RoutedEventArgs e)
        {
            if(Global.aktivnaNarudzba == null)
            {
                Global.aktivnaNarudzba = new Narudzbe();
                Global.aktivnaNarudzba.BrojNarudzbe = "1/" + DateTime.Now.Day + "-" + DateTime.Now.Year;
                Global.aktivnaNarudzba.Datum = DateTime.Now;
                Global.aktivnaNarudzba.KupacID = Global.prijavljeniKupac.KupacID;

            }
            bool proizvodPostoji = false;
            foreach(NarudzbaStavke item in Global.aktivnaNarudzba.NarudzbaStavkes)
            {
                if(proizvod.ProizvodID ==item.ProizvodID)
                {
                    item.Kolicina += Convert.ToInt32( kolicinaInput.Value);
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
                s.Kolicina =Convert.ToInt32( kolicinaInput.Value);
                Global.aktivnaNarudzba.NarudzbaStavkes.Add(s);
            }
            MessageDialog msg = new MessageDialog(message);
            await msg.ShowAsync();
            NarudzbaInfoLabel.Text = "Broj naručenih proizvoda: " + Global.aktivnaNarudzba.NarudzbaStavkes.Count();
            zakljuciButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }

        private void zakljuciButton_Click(object sender, RoutedEventArgs e)
        {
            if (kolicinaInput.Value == 0)
                kolicinaInput.Value = 1;
            Frame.Navigate(typeof(Profil.ActiveOrders));
        }


        private void ProizvodiList_OnItemClick(object sender, ItemClickEventArgs e)
        {
            List<string> sendItems = new List<string>();
            sendItems.Add(((Proizvodi)e.ClickedItem).ProizvodID.ToString());
            Frame.Navigate(typeof(Details), sendItems);
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
