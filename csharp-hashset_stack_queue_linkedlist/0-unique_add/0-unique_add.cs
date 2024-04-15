﻿using System;
using System.Collections.Generic;


class List
{
    public static int Sum(List<int> myList)
    {
        if (myList != null)
        {
            int compareVal = 0;
            int sum = 0;
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] != compareVal)
                {
                    compareVal = myList[i];
                    sum += myList[i];
                }
            }
            return sum;
        }
        return -1;
    }
}
