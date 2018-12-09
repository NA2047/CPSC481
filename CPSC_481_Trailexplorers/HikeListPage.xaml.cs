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
    /// Interaction logic for HikeListPage.xaml
    /// </summary>
    public partial class HikeListPage : UserControl
    {
        private String searchTextvalue = "";
        public String ds = null;
        public static Hashtable displayHikes = new Hashtable();
        private bool didSearch = false; 

        public HikeListPage()
        {
            InitializeComponent();
        
            //Hashtable results = FilterPage.filterResults;
            //displayHikes = loadCSV.SearchOption(results);
            CreateList();

        }

        public HikeListPage(String values)
        {
            InitializeComponent();

            Hashtable results = FilterPage.filterResults;
            displayHikes = loadCSV.SearchOption(results);
            CreateList();

        }

        private void Back_MouseDown(object sender, MouseEventArgs e)
        {
            Segue.Switch(new FilterPage());
        }

        private void CreateList()
        {
            //if (hikeListView == null)
            //{

            //}
            //else
            //{
                hikeListView.Children.Clear();
            //}
           
     
            foreach (DictionaryEntry pair in displayHikes)
            {
                HikeItem hikeitem = new HikeItem();

   
                Hike temp = (Hike)pair.Value;
                hikeitem.distanceDisplayLabel.Content = (string)temp.Distance + " km";
                hikeitem.elevationDisplayLabel.Content = (string)temp.Elevation + " m";
                string Ltime = temp.Time.Split(Convert.ToChar('-'))[0] + "hr" ;
                string Htime = temp.Time.Split(Convert.ToChar('-'))[1] + "hr";
                if(Ltime !=  Htime)
                {
                    hikeitem.timeDisplayLabel.Content = Ltime + " to " + Htime;
                }
                else
                {
                    hikeitem.timeDisplayLabel.Content =  Htime;
                }
              
                hikeitem.openClosedLabel.Content = temp.Open;
                hikeitem.parkNameDisplayLabel.Content = temp.Name;

                hikeListView.Children.Add(hikeitem);
            }

        }

        private void searchBoxInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            didSearch = true;
            hikeListView.Children.Clear();
            searchTextvalue = searchBoxInput.Text;

            if(searchTextvalue == "")
            {
                return;
            }
            Hashtable searchedHike = loadCSV.SearchInput(searchTextvalue);
            if (searchedHike.Count == 0)
            {
                return;
            }
            displayHikes = new Hashtable();
            displayHikes = searchedHike;
            CreateList();
           

        System.Diagnostics.Debug.WriteLine(searchTextvalue);
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Segue.Switch(new FilterPage());
        }

     
        private void BackToFilter_Click(object sender, RoutedEventArgs e)
        {
            Segue.Switch(new FilterPage());
        }
    }
}
