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
using eProdaja_UI.Model;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace eProdaja_Mob.Profil
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EditProfile : Page
    {

        private WebAPIHelper kupciService = new WebAPIHelper("http://localhost:60271/", "api/Kupci");
        private Kupci kupac;


        public EditProfile()
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
            BindProfile();
        }

        private void BindProfile()
        {
            kupac = Global.prijavljeniKupac;

            imeInputtxt.Text = kupac.Ime;
            prezimeInputtxt.Text = kupac.Prezime;
            emailInputtxt.Text = kupac.Email;
            korisnickoImeInputtxt.Text = kupac.KorisnickoIme;
            imeInputtxt.IsEnabled = false;
            prezimeInputtxt.IsEnabled = false;
            emailInputtxt.IsEnabled = false;
            korisnickoImeInputtxt.IsEnabled = false;
        }

     
        private void UrediBtn_OnClick(object sender, RoutedEventArgs e)
        {
            imeInputtxt.IsEnabled = true;
            prezimeInputtxt.IsEnabled = true;
            emailInputtxt.IsEnabled = true;
        }

        private async void SpasiPromjeneBtn_OnClick(object sender, RoutedEventArgs e)
        {
            kupac.Ime = imeInputtxt.Text;
            kupac.Prezime = prezimeInputtxt.Text;
            kupac.Email = emailInputtxt.Text;
            if (imeInputtxt.Text == "" || prezimeInputtxt.Text == "" || emailInputtxt.Text == "")
            {
                MessageDialog msg = new MessageDialog("Popunite prazna polja!");
                await msg.ShowAsync();

            }
            else
            {


                HttpResponseMessage response = kupciService.putResponse(kupac.KupacID, kupac);
                if (response.IsSuccessStatusCode)
                {
                    MessageDialog msg = new MessageDialog("Uspješno ste izmjenili podatke!");
                    await msg.ShowAsync();

                    Frame.Navigate(typeof(Profile));
                }
                else
                {
                    MessageDialog msg =
                        new MessageDialog(
                            "Desila se greška prilikom komuniciranja sa API servisom, molimo pokušajte kasnije!");
                    await msg.ShowAsync();
                }
            }
        }

        private void PromjeniPassBtn_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(EditPassword));
        }

        private void OdustaniBtn_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Profile));
        }

    }
}
