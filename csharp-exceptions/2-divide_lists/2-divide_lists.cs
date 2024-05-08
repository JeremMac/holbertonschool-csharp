using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> myList = new List<int>();
        int result = 0;
        for (int i = 0; i < listLength; i++)
        {
            try
            {
                result = list1[i]/list2[i];
                myList.Add(result);
            }
            catch (DivideByZeroException)
            {
                result = 0;
                myList.Add(result);
                Console.WriteLine("Cannot divide by zero");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }
        return myList;
    }
}
