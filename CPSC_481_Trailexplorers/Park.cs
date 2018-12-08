using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC_481_Trailexplorers
{
    public class Park
    {
        public string ParkName { get; set; }
        public int ParkId { get; set; }

        public int diff { get; set; }

        List<string> parks = new List<string> { "Banff National Park", "Jasper National Park", "Waterton Lakes National Park", "Glacier National Park", "Kootenay National Park", "Yoho National Park"};
    }
}
