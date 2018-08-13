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
    public sealed partial class RateDetails : Page
    {

        WebAPIHelper proizvodiService = new WebAPIHelper("http://localhost:60271/", "api/Proizvodi");
        WebAPIHelper ocjeneService = new WebAPIHelper("http://localhost:60271/", "api/Ocjene");
        private Proizvodi proizvod;
        public RateDetails()
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
            HttpResponseMessage response = proizvodiService.getActionResponse(e.Parameter.ToString());

            if (response.IsSuccessStatusCode)
            {
                proizvod = response.Content.ReadAsAsync<Proizvodi>().Result;

                nazivProizvodaTxt.Text = proizvod.Naziv;
                kategorijaTxt.Text = proizvod.Kategorija;


                MemoryStream ms = new MemoryStream(proizvod.SlikaThumb);
                BitmapImage image = new BitmapImage();

                await image.SetSourceAsync(ms.AsRandomAccessStream());

                proizvodImage.Source = image;
            }

        }

        private async void OcjeniProizvodButton_OnClick(object sender, RoutedEventArgs e)
        {

            if (ocjenaInputSlider.Value == 0)
                ocjenaInputSlider.Value = 1;

            Ocjene ocjena = new Ocjene();
            ocjena.KupacID = Global.prijavljeniKupac.KupacID;
            ocjena.ProizvodID = proizvod.ProizvodID;
            ocjena.Ocjena = Convert.ToInt32(ocjenaInputSlider.Value);
            ocjena.Datum = System.DateTime.Now;

            HttpResponseMessage response = ocjeneService.postResponse(ocjena);
            if (response.IsSuccessStatusCode)
            {
                MessageDialog msg = new MessageDialog("Uspjesno ste ocjenili proizvod!");
                await msg.ShowAsync();
                Frame.GoBack();
            }
        }

        private void slider2_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
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
