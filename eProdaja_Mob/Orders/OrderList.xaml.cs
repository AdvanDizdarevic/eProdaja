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
using eProdaja_PCL.Util;
using eProdaja_PCL.Model;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace eProdaja_Mob.Orders
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrderList : Page
    {

        private WebAPIHelper narudzbeService = new WebAPIHelper("http://localhost:60271/", "api/Narudzbe");

        public OrderList()
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
            BindNarudzbe();
        }

        private void BindNarudzbe()
        {
            HttpResponseMessage response = narudzbeService.getActionResponse("GetByKupacSum",
                 Global.prijavljeniKupac.KupacID.ToString());
            if (response.IsSuccessStatusCode)
            {
                narudzbeList.ItemsSource = response.Content.ReadAsAsync<List<Narudzbe>>().Result;
            }
        }

        private void NarudzbeList_OnItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(Orders.OrderListDetail), ((Narudzbe)e.ClickedItem).NarudzbaID);

        }
    }
}
