using System;
using System.Collections.Generic;

namespace AlgoBigOLab
{
    static class Algorithms
    {
        // Should be constant. Input never changes. O(1) 
        public static bool OddorEven(int RandomNumber)
        {
            Random rand = new Random();
            RandomNumber = rand.Next(1, 20);

            if (RandomNumber % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool LessThan100(List<int> RandomList)
        {
            RandomList = new List<int>()
            {
                70,
                65,
                99,
                110
            };
          
            for (int i = 0; i < RandomList.Count; i++)
            {
                if (RandomList[i] >= 100)
                {
                    return false;
                }
            }
            return true;
        }
        ////public static bool DuplicateNames(List<string> name)
        ////{
        ////    List<string> names = new List<string> { "Tron", "Alex", "Bob", "Alex", "Chuck" };

        ////    HashSet<string> NoDupes = new HashSet<string>();

        ////    foreach (string name in names)
        ////    {

        ////    }
        //}
    }
}
