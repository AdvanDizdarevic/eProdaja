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

namespace eProdaja_Mob.News
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NewsSearch : Page
    {

        private WebAPIHelper novostiService = new WebAPIHelper("http://localhost:60271/", "api/Novosti");

        public NewsSearch()
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
            BindNovosti();
        }

        private async void BindNovosti()
        {
            HttpResponseMessage response = novostiService.getResponse();
            if (response.IsSuccessStatusCode)
            {
                novostiList.ItemsSource = response.Content.ReadAsAsync<List<Novosti>>().Result;
            }
            else
            {
                MessageDialog msg = new MessageDialog("Api greska");
                await msg.ShowAsync();
            }
        }

        private void NovostiList_OnItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(NewsDetails), ((Novosti)e.ClickedItem).NovostID);
        }
    }
}
