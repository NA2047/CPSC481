using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xaml;
using System.Collections;


namespace CPSC_481_Trailexplorers
{
    /// <summary>
    /// Interaction logic for HikeItem.xaml
    /// </summary>
    public partial class HikeItem : UserControl
    {
        public HikeItem()
        {
            InitializeComponent();
          

        }

        private void Background_MouseDown(object sender, MouseButtonEventArgs e)
        {




            Segue.Switch(new HikeProfilePage(parkNameDisplayLabel.Content.ToString()));
        }

        private void MyWindow_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Image myimage = new System.Windows.Controls.Image();
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri("HikeProfileimages/" + parkNameDisplayLabel.Content.ToString() + ".jpg", UriKind.Relative);
            bi3.EndInit();

            Bitmap b = new Bitmap("../../HikeProfileimages/" + parkNameDisplayLabel.Content.ToString() + ".jpg");
            System.Drawing.Color x =  b.GetPixel(540, 200);
            System.Diagnostics.Debug.WriteLine(b.Width);
            System.Diagnostics.Debug.WriteLine(b.Height);


            myimage.Source = bi3;
            System.Diagnostics.Debug.WriteLine(background.Source.ToString());
            background.Source = bi3;
            background.Stretch = Stretch.UniformToFill;
            var brush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, (byte)x.R, (byte)x.G, (byte)x.B));
            //var converter = new System.Windows.Media.BrushConverter();
            //var brush = (System.Windows.Media.Brush)converter.ConvertFromString(x.ToString());
            backgroundGrid.Background = brush;
            
        }
    }
}
