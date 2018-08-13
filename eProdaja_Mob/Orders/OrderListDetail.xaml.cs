using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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

namespace eProdaja_Mob.Orders
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrderListDetail : Page
    {

        private WebAPIHelper narudzbeService = new WebAPIHelper("http://localhost:60271/", "api/Narudzbe");
        private NaruzbaList slika { get; set; }
        

        public OrderListDetail()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            BindProizvodi(Convert.ToInt32(e.Parameter.ToString()));
        }

        private async void BindProizvodi(int narudzbaID)
        {
            HttpResponseMessage response = narudzbeService.getActionResponseMessage("GetByKupacNarudzbaId", narudzbaID,
                Global.prijavljeniKupac.KupacID);
            if (response.IsSuccessStatusCode)
            {
                List<NaruzbaList> narudzbe = response.Content.ReadAsAsync<List<NaruzbaList>>().Result;
                proizvodiList.ItemsSource = narudzbe;
                datumNarudzbe.Text = "Datum: " + narudzbe[0].Datum.ToString("dd-MM-yyyy");

                //MemoryStream ms = new MemoryStream(slika.SlikaThumb);
                //BitmapImage image = new BitmapImage();

                //await image.SetSourceAsync(ms.AsRandomAccessStream());

                //ProizvodSlika.Source = image;
            }
        }
    }
}
