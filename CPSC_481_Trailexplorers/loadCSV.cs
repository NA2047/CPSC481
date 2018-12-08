using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Collections;

namespace CPSC_481_Trailexplorers
{
     static class loadCSV
    {
        public static List<Hike> bigList
        {
            get { return stuff(); }
            set { }
        }
        public static List<Hike> stuff()
        {
            List<Hike> allH = new List<Hike>(20);
            string line;
            FileStream aFile = new FileStream("../../files/parkData.csv", FileMode.Open);
            StreamReader sr = new StreamReader(aFile);
            line = sr.ReadLine();

            while ((line = sr.ReadLine()) != null)
            {
                //Console.WriteLine(line);
                String[] csvFields = line.Split(Convert.ToChar(","));
                //System.Diagnostics.Debug.WriteLine(csvFields.Length.ToString());
                Hike newHike = new Hike();
                String[] headers = { "Name","Park","Open","Distance","Elevation","Difficulty","Time","Description" };
                for (int i = 0; i< headers.Length; i++)
                {
                    newHike[headers[i]] = csvFields[i];
                 
                }
                allH.Add(newHike);

                
            }
            sr.Close();


            return allH;
                
        }

        public static Hashtable SearchOption(Hashtable param)
        {
              Hashtable poop = new Hashtable();

            foreach (Hike hike in bigList)
            {

                if(hike.Difficulty == (string)param["difficulty"] )
                {
                    poop[hike.Name] = hike;
                }
            }



            return poop;
        }

       
    }
}
