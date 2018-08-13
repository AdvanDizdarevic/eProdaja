using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;
using eProdaja_PCL.Model;

namespace eProdaja_Mob.Orders
{
   public class ImageConverter
    {
       public object Convert(object value, Type targetType, object parameter, string language)
       {
           if (value is Proizvodi)
           {
               MemoryStream ms = new MemoryStream(((Proizvodi) value).SlikaThumb);
               BitmapImage image = new BitmapImage();
               image.SetSourceAsync(ms.AsRandomAccessStream());
               return image;
           }
           if (value is AkcijskiProizvodis)

           {
               MemoryStream ms = new MemoryStream(((AkcijskiProizvodis) value).SlikaThumb);
               BitmapImage image = new BitmapImage();
               image.SetSourceAsync(ms.AsRandomAccessStream());
               return image;
           }
           else
           {
                return new BitmapImage(new Uri("ms-appx:///Assets/info.png"));
            }
       }

       public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return null;
        }
    }
}
