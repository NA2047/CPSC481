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
using System.Text.RegularExpressions;

namespace CPSC_481_Trailexplorers
{
    /// <summary>
    /// Interaction logic for HikeProfilePage.xaml
    /// </summary>
    public partial class HikeProfilePage : UserControl
    {
        private string v;
        private string hikename;

        public HikeProfilePage()
        {
          
            InitializeComponent();
            // loadimage
            //Image myimage = new Image();
            //BitmapImage bi3 = new BitmapImage();
            //bi3.BeginInit();
            //bi3.UriSource = new Uri("HikeProfileimages/"+hikeName.Content.ToString()+".jpg",UriKind.Relative);
            //bi3.EndInit();
            //myimage.Source = bi3;
            //System.Diagnostics.Debug.WriteLine(hikeImage.Source.ToString());
            //hikeImage.Source = bi3;
            //System.Diagnostics.Debug.WriteLine(hikeImage.Source.ToString());
            //hikeImage.Source = new Uri(hikeName.Content.ToString());
        }

        public HikeProfilePage(string v)
        {
            InitializeComponent();
            this.v = v;
            Hike hikeInfo = loadCSV.SearchByHikeName(v);

            hikeDescriptionValue.Text = hikeInfo.Description;
            hikeElevationValue.Content = hikeInfo.Elevation;
            hikeName.Content = hikeInfo.Name;
          
            hikeTimeValue.Content = hikeInfo.Time;
            hikeDistanceValue.Content = hikeInfo.Distance;
            hikeElevationValue.Content = hikeInfo.Elevation;
            hikeSeasonValue.Content = "fall";
            hikeDifficultyValue.Content = hikeInfo.Difficulty;
           

            string expr = @"(open)";
            Match result = Regex.Match(hikeInfo.Open, expr, RegexOptions.IgnoreCase);
            if (result.Success)
            {
                open.Foreground = new SolidColorBrush(Colors.MediumSpringGreen); 
         
            }
            else
            {
                open.Foreground = new SolidColorBrush(Colors.OrangeRed);
            }
           
            open.Content = hikeInfo.Open;

            // loadimage
            Image myimage = new Image();
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri("HikeProfileimages/" + v + ".jpg", UriKind.Relative);
            bi3.EndInit();
            myimage.Source = bi3;
            System.Diagnostics.Debug.WriteLine(hikeImage.Source.ToString());
            hikeImage.Source = bi3;
            System.Diagnostics.Debug.WriteLine(hikeImage.Source.ToString());
        }


        private void Back_MouseDown(object sender, MouseEventArgs e)
        {
            Segue.Switch(new HikeListPage("nope"));
        }

        //private void WebBrowser_Loaded(object sender, RoutedEventArgs e)
        //{
        //    webMap.Navigate(new Uri("https://www.google.ca/maps"));
        //    //WebBrowser.Navigating += OnNavigating;

        //}
        private void Home_Button(object sender, MouseEventArgs e)
        {
            Segue.Switch(new GuidePage());
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {

            GoogleMapPage googleMapPage = new GoogleMapPage();
            googleMapPage.setHike(hikeName.Content.ToString());
            Segue.Switch(googleMapPage);

        }


    }
}
