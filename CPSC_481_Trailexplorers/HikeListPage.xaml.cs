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
        private Hashtable hikes = new Hashtable();

        public HikeListPage()
        {
            InitializeComponent();
        
            Hashtable results = FilterPage.filterResults;
            hikes = loadCSV.SearchOption(results);
            createList();

        }

        public HikeListPage(String values)
        {
            InitializeComponent();

            Hashtable results = FilterPage.filterResults;
            hikes = loadCSV.SearchOption(results);
            createList();

        }

        private void Back_MouseDown(object sender, MouseEventArgs e)
        {
            Segue.Switch(new FilterPage());
        }

        private void createList()
        {
            //if (hikeListView == null)
            //{

            //}
            //else
            //{
                hikeListView.Children.Clear();
            //}
           
            //List<HikeItem> hikeList;

            //
            //HikeItem hikeitem1 = new HikeItem();
            //HikeItem hikeitem2 = new HikeItem();
            //HikeItem hikeitem3 = new HikeItem();
            //HikeItem hikeitem4 = new HikeItem();
            //HikeItem hikeitem5 = new HikeItem();
            //HikeItem[] RolesList = new HikeItem[] { hikeitem, hikeitem1, hikeitem2, hikeitem3, hikeitem4, hikeitem5 };

            foreach (DictionaryEntry pair in hikes)
            {
                HikeItem hikeitem = new HikeItem();

                //System.Diagnostics.Debug.WriteLine(item);
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
            searchTextvalue = searchBoxInput.Text;
            System.Diagnostics.Debug.WriteLine(searchTextvalue);
            //    test();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Segue.Switch(new FilterPage());
        }
    }
}
