using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC_481_Trailexplorers
{
    public class MyComboBoxItem
    {
        public string Name;
        public List<MyComboBoxItem> SubItems = new List<MyComboBoxItem>();

        public MyComboBoxItem(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
