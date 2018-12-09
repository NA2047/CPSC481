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
using System.Drawing;
using System.Xaml;


namespace CPSC_481_Trailexplorers
{
    /// <summary>
    /// Interaction logic for FilterPage.xaml
    /// </summary>
    public partial class FilterPage : UserControl
    {

        public static  Hashtable filterResults = new Hashtable();
        //private double decOrInc = double.MaxValue;

        public FilterPage()
        {
            InitializeComponent();
            this.DataContext = new MWVM();
            List<Hike> poop = loadCSV.bigList;
            foreach (Hike thing in poop)
            {
                System.Diagnostics.Debug.WriteLine(thing.Elevation);
            }

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
        public void Apply_Filter_Button(object sender, RoutedEventArgs e)
        {
            SaveSettings();
            GetSettings();
            if (Check_Location() && Check_Radio() && Check_Slider())
            {
                Segue.Switch(new HikeListPage());
        }
            else
            {
                filterResults.Clear();
            }


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

            if (filterResults.ContainsKey("park"))
            {
                filterResults["park"] =  dropDownPark.Text;
            }
            else
            {
                filterResults.Add("park", dropDownPark.Text);
            }
         
            return true;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Check_Radio()
        {

            var checkedButton = containerRadio.Children.OfType<RadioButton>().FirstOrDefault(r => (bool)r.IsChecked);
            if (checkedButton == null)
            {
                return false;
            }
            //filterResults.Add("difficulty", checkedButton.Content);
            if (filterResults.ContainsKey("difficulty"))
            {
                filterResults["difficulty"] = checkedButton.Content;
            }
            else
            {
                filterResults.Add("difficulty", checkedButton.Content);
            }

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

            if (sTime == 0 || sElevation == 0 || sDistance == 0)
            {
                return false;
            }


            //filterResults.Add("time", sliderTime.Value);
            //filterResults.Add("elevation", sliderElevation.Value);
            //filterResults.Add("distance", sliderDistance.Value);

            filterResults["time"] = sliderTime.Value;

            filterResults["elevation"] = sliderElevation.Value;

            filterResults["distance"] = sliderDistance.Value;

         
            return true;



        }


        public void SliderTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            //get reference 
            var slider = sender as Slider;
            //get value
            double value = slider.Value;

            //double DaySacle = poop.timeInt / 24.0;
            //double slideScale = 
            //System.Diagnostics.Debug.WriteLine(poop.darken.Opacity);

            if (animationView.DarkenUporDownP > slider.Value)
            {
                //going down
                animationView.darken.Opacity = (slider.Value / 24);
                animationView.DarkenUporDownP = slider.Value;
            }
            else
            {
                //going up 
                animationView.darken.Opacity = (slider.Value / 24);
                animationView.DarkenUporDownP = slider.Value;
            }


            timeValueLabel.Content = sliderTime.Value.ToString();

       


        }

        private void SliderDistance_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            distanceValueLabel.Content = sliderDistance.Value.ToString();
            //get reference 
            var slider = sender as Slider;
            //get value
            double value = slider.Value;

            var ratio = value / 10.0;

            var result = ratio * 65;
            animationView.MountainValueElevation =  result;
        }

        private void SliderElevation_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //get reference 
            var slider = sender as Slider;
            //get value
            double value = slider.Value;

            var ratio = value / 10.0;

            var result = ratio * 150;
            animationView.MountainValue = 150 - result;




            elevationValueLabel.Content = sliderElevation.Value.ToString();

            //if (decOrInc < sliderElevation.Value && elevationAnimationFill.Margin.Top >= 440)
            //{
            //    elevationAnimationFill.Margin = new Thickness(elevationAnimationFill.Margin.Left, elevationAnimationFill.Margin.Top - 4, elevationAnimationFill.Margin.Right, elevationAnimationFill.Margin.Bottom);
            //}
            //else {
            //    elevationAnimationFill.Margin = new Thickness(elevationAnimationFill.Margin.Left, elevationAnimationFill.Margin.Top + 4, elevationAnimationFill.Margin.Right, elevationAnimationFill.Margin.Bottom);

            //}
            //if (sliderElevation.Value == 0)
            //{
            //    decOrInc = double.MaxValue;
            //    elevationAnimationFill.Margin = new Thickness(elevationAnimationFill.Margin.Left, 550.00, elevationAnimationFill.Margin.Right, elevationAnimationFill.Margin.Bottom);
            //}
            //decOrInc = sliderElevation.Value;
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

        string easyCheck; 
        public void GetSettings()
        {
            //!if (easyRadio.IsChecked == true) easyCheck = easyRadio.Content.ToString();
            easyRadio.IsChecked= Properties.Settings.Default.Radio1;
            mediumRadio.IsChecked = Properties.Settings.Default.Radio2;
            hardRadio.IsChecked = Properties.Settings.Default.Radio3;

            Province.Text = Properties.Settings.Default.Province;
            dropDownPark.Text = Properties.Settings.Default.Park;

            sliderTime.Value = Properties.Settings.Default.sliderTime;
            sliderElevation.Value= Properties.Settings.Default.sliderElevation;
            sliderDistance.Value = Properties.Settings.Default.sliderDistance;




        }

        public void SaveSettings()
        {
            Properties.Settings.Default.Province = Province.Text;
            Properties.Settings.Default.Park = dropDownPark.Text;

            Properties.Settings.Default.Radio1 = easyRadio.IsChecked ?? false;
            Properties.Settings.Default.Radio2 = mediumRadio.IsChecked ?? false;
            Properties.Settings.Default.Radio3 = hardRadio.IsChecked ?? false;

            Properties.Settings.Default.sliderTime = sliderTime.Value;
            Properties.Settings.Default.sliderElevation= sliderElevation.Value;
            Properties.Settings.Default.sliderDistance = sliderDistance.Value;

            Properties.Settings.Default.Save();
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
            GetSettings();

        }

        private void easyRadio_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void mediumRadio_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void hardRadio_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void easyRadio_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
 