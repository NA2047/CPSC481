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
    /// Interaction logic for HikeListPage.xaml
    /// </summary>
    public partial class HikeListPage : UserControl
    {
        public HikeListPage()
        {
            InitializeComponent();
        }

        private void Back_MouseDown(object sender, MouseEventArgs e)
        {
            Segue.Switch(new FilterPage());
        }
    }
}
