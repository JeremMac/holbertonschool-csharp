using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList != null && myList.Count != 0)
        {
        int max = 0;
        string maxKey = "";
            foreach(KeyValuePair<string, int> item in myList)
            {
                if (item.Value => max)
                {
                    max = item.Value;
                    maxKey = item.Key;
                }
            }
            return maxKey;
        }
        return "None";
    }
}
