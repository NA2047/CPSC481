using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC_481_Trailexplorers
{
    public class Province
    {
        public string ProvinceName { get; set; }
        public int ProvinceId { get; set; }
        public List<Park> Parks{ get; set; }
        public List<Difficulty> DifficultyCollection { get; set; }

        public List<Slidercontrol1> SliderCollection { get; set; }

        public List<SliderControl2> SliderCollection2 { get; set; }
        
    }
}
