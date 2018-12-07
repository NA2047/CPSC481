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
    /// Interaction logic for testPage.xaml
    /// </summary>
    public partial class testPage : UserControl
    {


        public testPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider Slider1 = (Slider)sender;
            poop.MountainValue = 150 - Slider1.Value;








        }

        private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider Slider1 = (Slider)sender;
            poop.MountainValueElevation = Slider1.Value;
        }

        private void Slider_ValueChanged_2(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider Slider1 = (Slider)sender;

            //double DaySacle = poop.timeInt / 24.0;
            //double slideScale = 
            System.Diagnostics.Debug.WriteLine(poop.darken.Opacity);

            if (poop.DarkenUporDownP > Slider1.Value)
            {
                //going down
                poop.darken.Opacity = (Slider1.Value / 24);
                poop.DarkenUporDownP = Slider1.Value;
            }
            else
            {
                //going up 
                poop.darken.Opacity = (Slider1.Value / 24);
                poop.DarkenUporDownP = Slider1.Value;
            }
     

           
        }
    }
}
