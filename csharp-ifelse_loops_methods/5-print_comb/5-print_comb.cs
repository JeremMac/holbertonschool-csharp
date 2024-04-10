using System;

class Program
{
    public static void Main(string[] args)
    {
        for (int j = 0; j < 9; j++)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 10)
                {
                    j++;
                }
                Console.Write($"{j}{i}, ");
                if (j + i == 17)
                {
                    Console.Write("99\n");
                }
            }
        }
    }
}
