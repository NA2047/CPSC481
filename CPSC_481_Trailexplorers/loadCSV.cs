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
            Hashtable poop2 = param;
            double searchElevation = (double)param["elevation"];
            double searchTime = (double)param["time"];
            string searchPark = (string)param["park"]; 
            string searchDifficulty = (string)param["difficulty"];
            double searchDistance = (double)param["distance"]; 




            foreach (Hike hike in bigList)
            {

                String low = (string)hike.Time;
                String high = (string)hike.Time;
                double rangeL= double.Parse(low.Split(Convert.ToChar("-"))[0]);
                double rangeH = double.Parse(high.Split(Convert.ToChar("-"))[1]);

                if(hike.Difficulty == searchDifficulty && hike.Park == searchPark  && ((rangeL < searchTime && rangeH > searchTime) || (rangeL == searchTime || rangeH == searchTime)) && double.Parse(hike.Elevation) >= (searchElevation*100) &&  double.Parse(hike.Distance) <= searchDistance) 
                {
                    poop[hike.Name] = hike;
                }
            }



            return poop;
        }

       
    }
}
