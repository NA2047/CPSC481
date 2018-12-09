using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Text.RegularExpressions;

namespace CPSC_481_Trailexplorers
{
    static class loadCSV
    {
        public static List<Hike> bigList
        {
            get { return stuff(); }
            set { }
        }

        public static List<Hike> bigList2 = null;

        public static List<Hike> stuff()
        {
            List<Hike> allH = new List<Hike>(20);
            string line;
            FileStream aFile = new FileStream("../../files/parkData2.csv", FileMode.Open);
            StreamReader sr = new StreamReader(aFile);
            line = sr.ReadLine();

            while ((line = sr.ReadLine()) != null)
            {
                //Console.WriteLine(line);
                String[] csvFields = line.Split(Convert.ToChar(","));
                //System.Diagnostics.Debug.WriteLine(csvFields.Length.ToString());
                Hike newHike = new Hike();
                String[] headers = { "Name", "Park", "Open", "Distance", "Elevation", "Difficulty", "Time", "Description" };
                for (int i = 0; i < headers.Length; i++)
                {
                    newHike[headers[i]] = csvFields[i];

                }
                allH.Add(newHike);


            }
            sr.Close();

            bigList2 = allH;
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
                double rangeL = double.Parse(low.Split(Convert.ToChar("-"))[0]);
                double rangeH = double.Parse(high.Split(Convert.ToChar("-"))[1]);

                if (hike.Difficulty == searchDifficulty && hike.Park == searchPark && ((rangeL < searchTime && rangeH > searchTime) || (rangeL == searchTime || rangeH == searchTime)) && double.Parse(hike.Elevation) >= (searchElevation * 100) && double.Parse(hike.Distance) <= searchDistance)
                {
                    poop[hike.Name] = hike;
                }
            }



            return poop;
        }

        public static Hike SearchByHikeName(String name)
        {
            //string lowerCase = name.ToLower();
            string expr = @"(" + name + ")";


            Hike poop = new Hike();
            foreach (Hike hike in bigList2)
            {
                //MatchCollection mc = Regex.Matches(hike.Name, expr);
                Match result = Regex.Match(hike.Name, expr, RegexOptions.IgnoreCase);
                if (result.Success)
                {
                    poop = hike;
                    return poop;
                }

                //if (hike.Name == name)
                //{
                //    poop = hike;
                //    break;
                //}
            }


            poop = null;
            return poop;
        }

        //public static Hashtable SearchInput(String name)
        //{
        //    Hashtable poop = new Hashtable();
        //    string expr = @"(" + name + ")";

        //    foreach (Hike hike in bigList)
        //    {
        //        Match result = Regex.Match(hike.Name, expr, RegexOptions.IgnoreCase);
        //        if (result.Success)
        //        {
        //            poop[hike.Name] = hike;

        //        }
        //    }



        //    return poop;
        //}

        public static Hashtable SearchInput(String searchTerm)
        {
            //string lowerCase = name.ToLower();
            string expr = @"(.*?(" + searchTerm + "))";


            Hashtable poop = new Hashtable();
            foreach (Hike hike in bigList2)
            {
                string name = hike.Name;
                string open = hike.Open;
                string season = hike.Season;
                string time = hike.Time;
                string difficulty = hike.Difficulty;
                string distance = hike.Distance;
                string elevation = hike.Elevation;
                string description = hike.Description;



                //MatchCollection mc = Regex.Matches(hike.Name, expr);
                Match matchName = Regex.Match(name, expr, RegexOptions.IgnoreCase);
                Match matchOpen = Regex.Match(open, expr, RegexOptions.IgnoreCase);

                Match matchSeason = Regex.Match(season, expr, RegexOptions.IgnoreCase);

                Match matchTime = Regex.Match(time, expr, RegexOptions.IgnoreCase);

                Match matchDifficulty = Regex.Match(name, expr, RegexOptions.IgnoreCase);

                Match matchDistance = Regex.Match(distance, expr, RegexOptions.IgnoreCase);
                Match matchElevation = Regex.Match(elevation, expr, RegexOptions.IgnoreCase);
                Match matchDescription = Regex.Match(description, expr, RegexOptions.IgnoreCase);






                if (matchName.Success || matchOpen.Success || matchSeason.Success || matchTime.Success || matchDifficulty.Success || matchDistance.Success || matchElevation.Success || matchDescription.Success)
                {
                    poop[hike.Name] = hike;

                }


            }



            return poop;




        }
    }

}
