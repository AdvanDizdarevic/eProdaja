using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using eProdaja_PCL.Model;
using eProdaja_PCL.Util;
using System.Net.Http;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace eProdaja_Mob.News
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NewsDetails : Page
    {

        private WebAPIHelper novostiService = new WebAPIHelper("http://localhost:60271/", "api/Novosti");
        private Novosti novosti { get;set; }

        public NewsDetails()
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
            GetNovost(e.Parameter.ToString());
        }

        private async void GetNovost(string novostiId)
        {
            HttpResponseMessage response = novostiService.getActionResponse(novostiId);
            if (response.IsSuccessStatusCode)
            {
                novosti = response.Content.ReadAsAsync<Novosti>().Result;
                nazivNovostiTxt.Text = novosti.Naziv;
                sadrzajNovostiTextBlock.Text = novosti.Sadrzaj;
            }
            if (novosti.Slika != null)
            {
                MemoryStream ms = new MemoryStream(novosti.Slika);
                BitmapImage image = new BitmapImage();

                await image.SetSourceAsync(ms.AsRandomAccessStream());

                novostImage.Source = image;
            }
            else
            {
                novostImage.Source= new BitmapImage(new Uri("ms-appx:///Assets/add-to-cart-light.png"));
            }
        }


    }
}
