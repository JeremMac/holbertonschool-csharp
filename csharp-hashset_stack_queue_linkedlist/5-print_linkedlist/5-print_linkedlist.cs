using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> myLlist = new LinkedList<int>();
        if (size < 0)
        {
            return myLlist;
        }
        for(int i = 0; i < size; i++)
        {
            myLlist.AddLast(i);
        }
        foreach (var item in myLlist)
        {
            Console.WriteLine(item);
        }
        return myLlist;
    }
}
