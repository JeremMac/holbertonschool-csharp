using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> newlist = new List<int>();
        foreach  (int i in list1)
        {
            if (list2.Contains(i) == false)
            {
                newlist.Add(i);
            }
        }
        foreach (int i in list2)
        {
            if (!list1.Contains(i))
            {
                newlist.Add(i);
            }
        }
        newlist.Sort();
        return newlist;
    }
}
