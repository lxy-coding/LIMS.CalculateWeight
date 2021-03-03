using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace LIMS.Common
{
    public class WaitLoad
    {
        //private static Brush _background= new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));

        public static void Loading(UserControl UserControl, Action action)
        {
            object content= UserControl.Content;
            //Label lbl = new Label();
            //lbl.Background =Brushes.Transparent;
            //lbl.Width = 100;
            //lbl.Height = 100;
            //lbl.VerticalContentAlignment = VerticalAlignment.Center;
            //lbl.HorizontalContentAlignment = HorizontalAlignment.Center;
            Image img = new Image();
            img.Width = 120;
            img.Height = 120;
            //img.Source = new BitmapImage(new Uri("pack://application:,,,/LIMS.Common;component/Images/waiting.gif"));
            //img.Width = 200;
            //lbl.Content = img;
            //Panel.SetZIndex(lbl, 1000);
            UserControl.Content = img;
            WpfAnimatedGif.ImageBehavior.SetAnimatedSource(img, new BitmapImage(new Uri("pack://application:,,,/LIMS.Common;component/Images/waiting.gif")));
            Task task= Task.Run(action);
            task.ContinueWith(t=> {
                Application.Current.Dispatcher.Invoke(()=> {
                    UserControl.Content = content;
                });
            });
        }
    }
}
