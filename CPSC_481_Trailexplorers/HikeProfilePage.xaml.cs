using System;
using System.Collections.Generic;
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

namespace CPSC_481_Trailexplorers
{
    /// <summary>
    /// Interaction logic for HikeProfilePage.xaml
    /// </summary>
    public partial class HikeProfilePage : UserControl
    {
        public HikeProfilePage()
        {
          
            InitializeComponent();
            // loadimage
            Image myimage = new Image();
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri("HikeProfileimages/"+hikeName.Content.ToString()+".jpg",UriKind.Relative);
            bi3.EndInit();
            myimage.Source = bi3;
            System.Diagnostics.Debug.WriteLine(hikeImage.Source.ToString());
            hikeImage.Source = bi3;
            System.Diagnostics.Debug.WriteLine(hikeImage.Source.ToString());
            //hikeImage.Source = new Uri(hikeName.Content.ToString());
        }

        private void Back_MouseDown(object sender, MouseEventArgs e)
        {
            Segue.Switch(new HikeListPage());
        }

        //private void WebBrowser_Loaded(object sender, RoutedEventArgs e)
        //{
        //    webMap.Navigate(new Uri("https://www.google.ca/maps"));
        //    //WebBrowser.Navigating += OnNavigating;

        //}
        private void Home_Button(object sender, MouseEventArgs e)
        {
            Segue.Switch(new FilterPage());
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {

            GoogleMapPage googleMapPage = new GoogleMapPage();
            googleMapPage.setHike(hikeName.Content.ToString());
            Segue.Switch(googleMapPage);

        }
    }
}
