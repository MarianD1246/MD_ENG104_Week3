using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            int allFives = max / 5;
            List<int> listOfFive = new List<int>();
            for (int i = 1; i <= allFives; i++)
            {
                listOfFive.Add(i*5);
            }
            return listOfFive;
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            if (sourceList == null || sourceList.Count == 0 || sourceList.Count == 1)
            {
                return sourceList;
            }
            List<string> aList = new();

            foreach (string s in sourceList)
            {
                if (s.ToLower()[0] == 'a')
                {
                    aList.Add(s);
                }
            } 
            return aList;
        }
    }
}
