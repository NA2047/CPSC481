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
    /// Interaction logic for GoogleMapPage.xaml
    /// </summary>
    public partial class GoogleMapPage : UserControl
    {
        private String hikename = null;
        private String query = null;
        public GoogleMapPage()
        {
       
        InitializeComponent();
        }

        private void WebBrowser_Loaded(object sender, RoutedEventArgs e)
        {
            googleMaps.Navigate(new Uri(query));
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Segue.Switch(new HikeProfilePage());
        }

        public void setHike(String value)
        {
            hikename = value;
            StringBuilder queryAddress = new StringBuilder();
            queryAddress.Append("http://maps.google.com/maps?q=");
            queryAddress.Append(value);
            query = queryAddress.ToString();

        }
    }
}
