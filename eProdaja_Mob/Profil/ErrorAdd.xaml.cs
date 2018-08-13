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
using eProdaja_PCL.Util;
using eProdaja_PCL.Model;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace eProdaja_Mob.Profil
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ErrorAdd : Page
    {
        private WebAPIHelper greskaService = new WebAPIHelper("http://localhost:60271/", "api/Greska");
        private Greska greska;
        public ErrorAdd()
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
        }

        private void OdustaniBtn_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Profile));
        }

        private async void PrijaviBtn_OnClick(object sender, RoutedEventArgs e)
        {
            greska = new Greska();
            greska.Naziv = nazivInputtxt.Text;
            greska.Sadrzaj = sadrzajInputtxt.Text;
            greska.DatumPostavljanja = System.DateTime.Now;
            greska.KupacID = Global.prijavljeniKupac.KupacID;
            greska.Status = true;
            greska.Pregledana = false;
            if (nazivInputtxt.Text == "" || sadrzajInputtxt.Text == "")
            {
                MessageDialog msg = new MessageDialog("Popunite prazna polja!");
                await msg.ShowAsync();

            }
            else
            {


                HttpResponseMessage response = greskaService.postResponse(greska);
                if (response.IsSuccessStatusCode)
                {
                    MessageDialog msg = new MessageDialog("Uspješno ste prijavili gresku!");
                    await msg.ShowAsync();

                    Frame.Navigate(typeof(Profile));
                }
                else
                {
                    MessageDialog msg = new MessageDialog("Došlo je do greške prilikom komuniciranja sa API servisomm!");
                    await msg.ShowAsync();
                }
            }
        }
    }
    
}
