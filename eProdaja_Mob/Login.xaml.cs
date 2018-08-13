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
using eProdaja_PCL.Util;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace eProdaja_Mob
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {

        WebAPIHelper serviceCaller = new WebAPIHelper("http://localhost:60271/", "api/Kupci");
        public Login()
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
        private async void prijavaButton_Click(object sender, RoutedEventArgs e)
        {
            HttpResponseMessage response = serviceCaller.getActionResponse("GetKupciByUsername", korisnickoImeInput.Text);
            string message = string.Empty;
            if (response.IsSuccessStatusCode)
            {
                Kupci kupac = response.Content.ReadAsAsync<Kupci>().Result;

                if (UIHelper.GenerateHash(lozinkaInput.Password, kupac.LozinkaSalt) == kupac.LozinkaHash)
                {
                    Global.prijavljeniKupac = kupac;
                    message = "Welcome " + kupac.Ime + " " + kupac.Prezime;
                    Frame.Navigate(typeof(MainPage));
                }
                else { message = "Pogrešna lozinka."; }
          }
            else  { message = "Pogrešno korisničko ime."; }
        
            MessageDialog msg = new MessageDialog(message);
            await msg.ShowAsync();
        }

         
        private void registracijaButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Registracija));
        }
    }
}
