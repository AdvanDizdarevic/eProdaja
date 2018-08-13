using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Imaging;
using eProdaja_PCL.Model;

namespace eProdaja_Mob.News
{
        public class ImageConverter : IValueConverter
        {

            public object Convert(object value, Type targetType, object parameter, string language)
            {
                if (((Novosti)value).Slika != null)
                {
                    MemoryStream ms = new MemoryStream(((Novosti)value).Slika);

                    BitmapImage image = new BitmapImage();
               image.SetSourceAsync(ms.AsRandomAccessStream());
                    return image;
                }
                else
                {
                    return new BitmapImage(new Uri("ms-appx:///Assets/info.png"));
                    /*var uri = new System.Uri("ms-appx:///Assets/shop-cart-add-icon.png");
                    var file = Windows.Storage.StorageFile.GetFileFromApplicationUriAsync(uri);
                    return file;*/
                }

            }

            public object ConvertBack(object value, Type targetType, object parameter, string language)
            {
                return null;
            }
        }
    }

