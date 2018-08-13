using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Web.Http.Headers;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace eProdaja_Mob
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            HardwareButtons.BackPressed += HardwareButtons_BackPressed;
       }

        private void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            Frame.GoBack();
            e.Handled = true;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if(Global.prijavljeniKupac !=null)
            {
                prijavaButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                profilButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                welcometext.Visibility= Windows.UI.Xaml.Visibility.Visible;
                narudzbeHist.Visibility = Windows.UI.Xaml.Visibility.Visible;
                btnRate.Visibility= Windows.UI.Xaml.Visibility.Visible;

            }
        }

        private void proizvodiButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Products.Search));
        }

        private void prijavaButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Login));
        }

        private void profilButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Profil.Profile));
        }

        private void akcijaButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Products.Action));
        }

        private void NovostiButton_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(News.NewsSearch));
        }

        private void NarudzbeHist_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Orders.OrderList));
        }

        private void BtnRate_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Products.RateList));
        }
    }
}
