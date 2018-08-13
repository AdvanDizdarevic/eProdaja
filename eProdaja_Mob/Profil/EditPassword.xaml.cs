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
using eProdaja_UI.Util;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace eProdaja_Mob.Profil
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EditPassword : Page
    {

        private WebAPIHelper kupciService = new WebAPIHelper("http://localhost:60271/", "api/Kupci");
        private Kupci kupac;

        public EditPassword()
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
            noviPassPanel.Visibility = Visibility.Collapsed;
            noviPassPanel1.Visibility = Visibility.Collapsed;
            noviPassPanel2.Visibility = Visibility.Collapsed;
            kupac = Global.prijavljeniKupac;
        }

        private async void StariPassBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (kupac.LozinkaHash == UIHelper.GenerateHash(stariPassInputtxt.Password, kupac.LozinkaSalt))
            {
                noviPassPanel.Visibility = Visibility.Visible;
                noviPassPanel1.Visibility = Visibility.Visible;
                noviPassPanel2.Visibility = Visibility.Visible;
                stariPassPanel.Visibility = Visibility.Collapsed;
            }
            else
            {
                MessageDialog dialog =
                    new MessageDialog("Pogriješili ste lozinku!!!");
                await dialog.ShowAsync();
            }
        }

        private async void PromjeniPassBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (noviPassInputtxt.Password == noviPassAgainInputtxt.Password)
            {
                kupac.LozinkaSalt = UIHelper.GenerateSalt();
                kupac.LozinkaHash = UIHelper.GenerateHash(noviPassInputtxt.Password,
                    kupac.LozinkaSalt);
                if (noviPassInputtxt.Password == "" || noviPassAgainInputtxt.Password == "")
                {
                    MessageDialog msg = new MessageDialog("Popunite prazna polja!");
                    await msg.ShowAsync();

                }
                else
                {


                    HttpResponseMessage response = kupciService.putResponse(Global.prijavljeniKupac.KupacID, kupac);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageDialog msg = new MessageDialog("Uspješno ste promjenili lozinku!!!");
                        await msg.ShowAsync();

                        Frame.GoBack();
                    }
                    else
                    {
                        MessageDialog dialog =
                            new MessageDialog("Greška u API-u, pokušajte kasnije !!!");
                        await dialog.ShowAsync();
                    }
                }
            }
            else
                {
                    MessageDialog dialog =
                        new MessageDialog("Lozinke se ne slažu!!!");
                    await dialog.ShowAsync();
                }
            

        }
    }
}
