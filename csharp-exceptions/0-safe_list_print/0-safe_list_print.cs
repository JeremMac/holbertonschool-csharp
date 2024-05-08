using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;
        try
        {
            while(count < n)
            {
                Console.WriteLine(myList[count]);
                count++;
            }
        }
        catch (Exception e)
        {

        }
        return count;
    }
}
