using System;

class Program
{
    public static void Main(string[] args)
    {
        int j = 0;
        int i = 0;
            for (i = 0; i < 11; i++)
            {
                if (i == 10)
                {
                    j++;
                    i = 0;
                }
                Console.Write($"{j}{i}, ");
                if (j == 9 && i == 8)
                {
                    Console.Write("99\n");
                    break;
                }
            }
    }
}
