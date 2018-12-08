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
    public partial class BanffHikeNames: UserControl
    {
        public string banffHikenames { get; set; }

        public string hname;
        public void Hikename(string name)
        {
            hname=name;
            
        }

        public int HikeElevation { get; set; }
        public int HikeTime { get; set; }
        public int HikeDistance { get; set; }

        public string HikeDescription { get; set; }
        public int HikeId { get; set; }

        List<string> hikes = new List<string> { "Cory Pass", "Cascade Amphitheatre", "Bourgeau Lake and Harvey Pass", "Glacier National Park", "Big Beehive", "Plain of Six Glaciers" };









        //HikeListPage b = new HikeListPage();
        

        
    }

    
}

