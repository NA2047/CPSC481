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
    public partial class HikeListPage: UserControl 
    {
        public String searchTextvalue = ""; 
        
        public List<string> banffNames = null;

        BanffHikeNames Hike1 = new BanffHikeNames();
        //Hike1.Hikename("CoryPass"); 

        public List<string> Bname { get { return banffNames; } set { banffNames = value; } }
        
        

        public HikeListPage()
        {
            InitializeComponent();
            //List<string> hikes = new List<string> { "Banff National Park", "Jasper National Park", "Waterton National Park"};
            //dropdownpark.ItemsSource = hikes;
            //test();

        }

        public void Back_MouseDown(object sender, MouseEventArgs e)
        {
            Segue.Switch(new FilterPage());
        }

        /*private void test()
        {
            //if (hikeListView == null)
            //{

            //}
            //else
            //{
                hikeListView.Children.Clear();
            //}
           
            List<HikeItem> hikeList;

            HikeItem hikeitem = new HikeItem();
            HikeItem hikeitem1 = new HikeItem();
            HikeItem hikeitem2 = new HikeItem();
            HikeItem hikeitem3 = new HikeItem();
            HikeItem hikeitem4 = new HikeItem();
            HikeItem hikeitem5 = new HikeItem();
            HikeItem[] RolesList = new HikeItem[] { hikeitem, hikeitem1, hikeitem2, hikeitem3, hikeitem4, hikeitem5 };

            foreach (var item in RolesList)
            {
                hikeListView.Children.Add(item);
            }

        }*/

        public void searchBoxInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            searchTextvalue = searchBoxInput.Text;
            System.Diagnostics.Debug.WriteLine(searchTextvalue);
            //    test();
        }
    }
}
