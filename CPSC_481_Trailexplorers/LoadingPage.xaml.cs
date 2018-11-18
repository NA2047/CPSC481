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
using System.Windows.Threading;


namespace CPSC_481_Trailexplorers
{
    /// <summary>
    /// Interaction logic for LoadingPage.xaml
    /// </summary>
    public partial class LoadingPage : UserControl
    {

        DispatcherTimer timr = new DispatcherTimer();


        public LoadingPage()
        {
            InitializeComponent();
            FadeInAndOut();
            

        }

        private void FadeInAndOut()
        {
          

        }

        private void aPicture_MouseDown(object sender, MouseEventArgs e)
        {
            Segue.Switch(new FilterPage());
        }
    }
}
