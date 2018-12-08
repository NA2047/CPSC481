using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC_481_Trailexplorers
{
    class Hike
    {
        private String elevation = "yo";
        private String time = "hr";
        private String distance = "km";
        private String name = "Park Name";
        private String open = "open";
        private String difficulty = "how hard";
        private String season = "fall";
        private String description = "tell me";
        private String park = "tell me";
      
        public Hike()
        {
          
        }

        public object this[string propertyName]
        {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set {

                this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }

        public string Bar { get; set; }

        public String Elevation { get => elevation; set => elevation = value; }
        public string Time { get => time; set => time = value; }
        public string Distance { get => distance; set => distance = value; }
        public string Name { get => name; set => name = value; }
        public string Open { get => open; set => open = value; }
        public string Difficulty { get => difficulty; set => difficulty = value; }
        public string Season { get => season; set => season = value; }
        public string Description { get => description; set => description = value; }
        public string Park { get => park; set => park = value; }
    }
}
