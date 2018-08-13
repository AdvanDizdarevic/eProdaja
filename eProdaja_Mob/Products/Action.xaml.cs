using eProdaja_PCL.Util;
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

using eProdaja_UI.Model;
using eProdaja_PCL.Util;
using eProdaja_PCL.Model;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace eProdaja_Mob.Products
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Action : Page
    {

        private WebAPIHelper akcijskiProizvodiService = new WebAPIHelper("http://localhost:60271/", "api/AkcijskiProizvodi");
        public Action()
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

        private async void BindProizvodi()
        {
            HttpResponseMessage response = akcijskiProizvodiService.getActionResponse("GetTrenutnoAktivni");
            if (response.IsSuccessStatusCode)
            {
                List<AkcijskiProizvodis> akcijskiProizvodi = response.Content.ReadAsAsync<List<AkcijskiProizvodis>>().Result;
                if (akcijskiProizvodi.Count == 0)
                {
                    MessageDialog msg = new MessageDialog("Trenutno nema proizvoda na akciji!");
                    await msg.ShowAsync();
                }
                else
                    proizvodiList.ItemsSource = akcijskiProizvodi;

            }
        }

        private void ProizvodiList_OnItemClick(object sender, ItemClickEventArgs e)
        {
            List<string> sendItems = new List<string>();
            sendItems.Add(((AkcijskiProizvodis)e.ClickedItem).ProizvodID.ToString());
            sendItems.Add(((AkcijskiProizvodis)e.ClickedItem).Popust.ToString());
           
            Frame.Navigate(typeof(DiscountProdDetail), sendItems);
        }
    }
}
