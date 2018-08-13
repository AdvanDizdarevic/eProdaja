using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
using eProdaja_UI.Model;
using eProdaja_UI.Util;
using System.Net.Http;
using eProdaja_PCL.Model;
using eProdaja_PCL.Util;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace eProdaja_Mob.Products
{


    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Search : Page
    {

        WebAPIHelper vrsteProizvodaservice = new WebAPIHelper("http://localhost:60271/", "api/KategorijeProizvoda");
        WebAPIHelper proizvodiService = new WebAPIHelper("http://localhost:60271/", "api/Proizvodi");

        public Search()
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
            BindVrstaProizvoda();
            BindProizvodi();
            BindByNaziv();
            BindBySifra();
        }

        private void BindBySifra()
        {
            HttpResponseMessage response = proizvodiService.getActionResponse("GetProizvodBySifraList", searchsifra.Text);
            if (response.IsSuccessStatusCode)
            {
                proizvodiList.ItemsSource = response.Content.ReadAsAsync<List<Proizvodi>>().Result;
            }
        }

        private void BindByNaziv()
        {
            HttpResponseMessage response = proizvodiService.getActionResponse("GetProizvodiByNaziv", searchStringTxt.Text);
            if (response.IsSuccessStatusCode)
            {
                proizvodiList.ItemsSource = response.Content.ReadAsAsync<List<Proizvodi>>().Result;
            }
        }

        private void BindProizvodi()
        {
            int kategID = 0;
            if (vrsteProizvodaList.SelectedIndex != -1)
                kategID = ((KategorijeProzvoda)vrsteProizvodaList.SelectedValue).KategorijaID;
            HttpResponseMessage response = proizvodiService.getActionResponse("SearchProizvodiByVrsta",kategID.ToString());
            if(response.IsSuccessStatusCode)
            {
                proizvodiList.ItemsSource = response.Content.ReadAsAsync<List<Proizvodi>>().Result;
            }
        }

        private void BindVrstaProizvoda()
        {
            HttpResponseMessage resposnse = vrsteProizvodaservice.getResponse();
            if(resposnse.IsSuccessStatusCode)
            {
                vrsteProizvodaList.ItemsSource = resposnse.Content.ReadAsAsync<List<KategorijeProzvoda>>().Result;
                vrsteProizvodaList.DisplayMemberPath = "Naziv";
            }
        }

        private void vrsteProizvodaList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BindProizvodi();
        }

        private void proizvodiList_ItemClick(object sender, ItemClickEventArgs e)
        {

            List<string> sendItems = new List<string>();
            sendItems.Add(((Proizvodi)e.ClickedItem).ProizvodID.ToString());
           

            Frame.Navigate(typeof(Details), sendItems);
        }


        private void SearchStringTxt_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            BindByNaziv();
        }


        private void Searchsifra_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            BindBySifra();
        }

     
    }
}
