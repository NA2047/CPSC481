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
using System.Xaml;


namespace CPSC_481_Trailexplorers
{
    /// <summary>
    /// Interaction logic for GuidePage.xaml
    /// </summary>
    public partial class GuidePage : UserControl
    {
        public GuidePage()
        {
            InitializeComponent();
        }

        private void Find_Hike(object sender, RoutedEventArgs e)
        {
            Segue.Switch(new HikeListPage());
        }

        private void Help_Filter(object sender, RoutedEventArgs e)
        {
            Segue.Switch(new FilterPage());
        }



    }
}
