using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array != null)
        {
            int length = array.Length -1;
            for (int i = length; i >= 0; i--)
            {
                Console.Write(array[i]);
                if (array.Length > 1)
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }
}
