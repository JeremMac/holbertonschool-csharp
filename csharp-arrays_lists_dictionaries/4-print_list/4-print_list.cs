using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        List<int> list = new List<int>();
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        for (int i = 0; i < size; i++)
        {
            list.Add(i);
            if (i != size - 1)
            {
                Console.Write(list[i] + " ");
            }
            else if (i == size - 1)
            {
                Console.WriteLine(list[i]);
            }
            else
            {
                Console.Write(list[i]);
            }
        }
        return list;
    }
}
