﻿class Program
{
    static void Main(string[] args)
    {
        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            if (letter != 'e' && letter != 'q')
            {
                Console.Write(letter);
            }
        }
    }
}
