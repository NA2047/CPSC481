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
        public static Hashtable bigList
        {
            get { return stuff(); }
            set { }
        }

        public static Hashtable bigList2 = new Hashtable();

        public static Hashtable stuff()
        {
            Hashtable allH = new Hashtable();
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
                allH[newHike.Name] = newHike;


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




            foreach (DictionaryEntry pair in bigList2)
            {
                Hike hike = (Hike)pair.Value;
                String low = hike.Time;
                String high = hike.Time;
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
            foreach (DictionaryEntry pair in bigList2)
            {
                //MatchCollection mc = Regex.Matches(hike.Name, expr);
                Hike hike = (Hike)pair.Value;
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
            String expr = @"(.*?(" + searchTerm + "))";

            searchTerm = searchTerm.ToLower();
            Hashtable poop = new Hashtable();
            foreach (DictionaryEntry pair in bigList2)
            {
                Hike hike = (Hike)pair.Value;
                string name = hike.Name.ToLower();
                string park = hike.Park.ToLower();
                string open = hike.Open.ToLower();
                string season = hike.Season.ToLower();
                string time = hike.Time.ToLower();
                string difficulty = hike.Difficulty.ToLower();
                string distance = hike.Distance.ToLower();
                string elevation = hike.Elevation.ToLower();
                string description = hike.Description.ToLower();
                //int gp = difficulty.IndexOf(searchTerm);



                //MatchCollection mc = Regex.Matches(hike.Name, expr);
                //Match matchName = Regex.Match(name, expr, RegexOptions.IgnoreCase);
                //Match matchOpen = Regex.Match(open, expr, RegexOptions.IgnoreCase);

                //Match matchSeason = Regex.Match(season, expr, RegexOptions.IgnoreCase);

                //Match matchTime = Regex.Match(time, expr, RegexOptions.IgnoreCase);

                //Match matchDifficulty = Regex.Match(name, expr, RegexOptions.IgnoreCase);

                //Match matchDistance = Regex.Match(distance, expr, RegexOptions.IgnoreCase);
                //Match matchElevation = Regex.Match(elevation, expr, RegexOptions.IgnoreCase);
                //Match matchDescription = Regex.Match(description, expr, RegexOptions.IgnoreCase);

                int matchName = name.IndexOf(searchTerm);
                int matchOpen = open.IndexOf(searchTerm);
                int matchPark = park.IndexOf(searchTerm);

                int matchSeason = season.IndexOf(searchTerm);

                int matchTime = time.IndexOf(searchTerm);

                int matchDifficulty = difficulty.IndexOf(searchTerm);

                int matchDistance = distance.IndexOf(searchTerm);
                int matchElevation = elevation.IndexOf(searchTerm);
                int matchDescription = description.IndexOf(searchTerm);





                if (matchName == 0 || matchOpen == 0 || matchSeason == 0 || matchTime == 0 || matchDifficulty == 0 || matchDistance == 0 || matchElevation == 0 || matchDescription == 0 || matchPark == 0)
                {
                    poop[hike.Name] = hike;
                }


            }



            return poop;




        }
    }

}
