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
using System.Collections;



namespace CPSC_481_Trailexplorers
{
    /// <summary>
    /// Interaction logic for FilterPage.xaml
    /// </summary>
    public partial class FilterPage : UserControl
    {

        Hashtable filterResults = new Hashtable();

        public FilterPage()
        {
            InitializeComponent();
            this.DataContext = new MWVM();

        }
        /// <summary>
        /// Moves View back to GuidePage Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_MouseDown(object sender, MouseEventArgs e)
        {
            Segue.Switch(new GuidePage());
        }

        /// <summary>
        /// send filter results here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Apply_Filter_Button(object sender, RoutedEventArgs e)
        {

            //if(Check_Location() && Check_Radio() && Check_Slider())
            //{
                Segue.Switch(new HikeListPage());
            //}
            //else
            //{
            //    filterResults.Clear();
            //}

            
        }

         /// <summary>
         /// 
         /// </summary>
         /// <returns></returns>
        private bool Check_Location()
        {
          
            if (string.IsNullOrEmpty(Province.Text) || string.IsNullOrEmpty(dropDownPark.Text))
            {
                return false;
            }

          
            filterResults.Add("province", Province.Text);
            filterResults.Add("park", dropDownPark.Text);
            return true;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool Check_Radio()
        {

            var checkedButton = containerRadio.Children.OfType<RadioButton>().FirstOrDefault(r => (bool)r.IsChecked);
            if (checkedButton == null)
            {
                return false;
            }
            filterResults.Add("difficulty", checkedButton.Name);
            

            return true;
         
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool Check_Slider()
        {
            Double sTime = sliderTime.Value;
            Double sElevation = sliderElevation.Value;
            Double sDistance = sliderDistance.Value;

            if(sTime == 0 || sElevation == 0 || sDistance == 0)
            {
                return false;
            }
            filterResults.Add("time", sliderTime.Value);
            filterResults.Add("elevation", sliderElevation.Value);
            filterResults.Add("distance", sliderDistance.Value);
            return true;



        }


        private void SliderTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            timeValueLabel.Content = sliderTime.Value.ToString();
        }

        private void SliderDistance_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            distanceValueLabel.Content = sliderDistance.Value.ToString();
        }

        private void SliderElevation_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            elevationValueLabel.Content = sliderElevation.Value.ToString();
        }

        private void dropDownPark_Loaded(object sender, RoutedEventArgs e)
        {
              
        }

        private void Province_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dropDownPark_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
