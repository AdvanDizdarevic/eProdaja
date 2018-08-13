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
using Windows.UI.Xaml.Navigation;
using eProdaja_PCL.Model;
using eProdaja_PCL.Util;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace eProdaja_Mob.Profil
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ActiveOrders : Page
    {
        WebAPIHelper narudzbeService = new WebAPIHelper("http://localhost:60271/", "api/Narudzbe");
       
        public ActiveOrders()
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
            BindNarudzba();
        }

        private void BindNarudzba()
        {
            
            if(Global.aktivnaNarudzba!=null)
            {
                narudzbaList.ItemsSource = Global.aktivnaNarudzba.NarudzbaStavkes;
                
           
            decimal iznos = 0;
            foreach (NarudzbaStavke item in Global.aktivnaNarudzba.NarudzbaStavkes)
            {
                iznos += item.Proizvodi.Cijena * item.Kolicina;
            }
            iznosLabel.Text = "Ukupan iznos: " + Math.Round(iznos, 2) + "KM";
        }
            else
            {
                zakljuciButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
        }

        private async void zakljuciButton_Click(object sender, RoutedEventArgs e)
        {
            string message = string.Empty;
            HttpResponseMessage respose = narudzbeService.postResponse(Global.aktivnaNarudzba);
            if(respose.IsSuccessStatusCode)
            {
                message = "Uspjesno ste zakljucili narudžbu!";
                  
                Global.aktivnaNarudzba = null;
               
            }
            else
            {
                message = "Narudžba nije dodata ->" + respose.ReasonPhrase;
            }

            MessageDialog msg = new MessageDialog(message);
            await msg.ShowAsync();
            Frame.Navigate(typeof(Products.RateList));
        }

     
    }
}
