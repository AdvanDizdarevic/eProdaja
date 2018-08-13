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
using Windows.UI.Xaml.Navigation;
using eProdaja_PCL.Model;
using eProdaja_PCL.Util;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace eProdaja_Mob.Products
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RateList : Page
    {

        WebAPIHelper proizvodiService = new WebAPIHelper("http://localhost:60271/", "api/Proizvodi");
        private Proizvodi proizvod { get; set; }

        public RateList()
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
            BindProizvodi();
        }

        private void BindProizvodi()
        {
            HttpResponseMessage response = proizvodiService.getActionResponse("GetNeocjenjeniProizvodi",
               Global.prijavljeniKupac.KupacID.ToString());
            if (response.IsSuccessStatusCode)
            {
                proizvodiList.ItemsSource = response.Content.ReadAsAsync<List<Proizvodi>>().Result;

            }
        }

        private void ProizvodiList_OnItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(Products.RateDetails),((Proizvodi)e.ClickedItem).ProizvodID);
        }

        private void Otkazi_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
