using eProdaja_PCL.Util;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace eProdaja_Mob
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Registracija : Page
    {

        WebAPIHelper service = new WebAPIHelper("http://localhost:60271/", "api/Kupci");

       
        public Registracija()
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

        private async void btnRegistracija_Click(object sender, RoutedEventArgs e)
        {
           
               Kupci k = new Kupci();
                k.Ime = inputIme.Text;
                k.Prezime = inputPrezime.Text;
                k.Email = inputEMail.Text;
                k.KorisnickoIme = inputKorisnickoIme.Text;
                k.LozinkaSalt = UIHelper.GenerateSalt();
                k.LozinkaHash = UIHelper.GenerateHash(inputPassword.Password, k.LozinkaSalt);
                k.DatumRegistracije = DateTime.Now;
                k.Status = true;




                if (inputIme.Text == "" || inputPrezime.Text == "" || inputEMail.Text == "" || inputPassword.Password == "" || inputKorisnickoIme.Text=="")
                {
                    MessageDialog msg = new MessageDialog("Popunite prazna polja!");
                    await msg.ShowAsync();
                }
                else
                {
                    HttpResponseMessage response = service.postResponse(k);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageDialog msg1 = new MessageDialog("Registracija uspjesna!");
                        await msg1.ShowAsync();
                        Frame.Navigate(typeof(Login));
                    }
                    else
                    {
                        MessageDialog msg1 = new MessageDialog("Doslo je do greske:" + response.ReasonPhrase);
                        await msg1.ShowAsync();

                    }
                }
            
           
                
            

        }

        private void btnPrekid_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Login));
        }
    }
}
