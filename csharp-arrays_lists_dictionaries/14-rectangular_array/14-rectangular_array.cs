using System;

class Program {
    public static void Main() {
        int [,] rectangularArray = new int[5, 5];

        rectangularArray[2,2] = 1;

        for (int i = 0; i < rectangularArray.GetLength(0); i++) {
            for (int j = 0; j < rectangularArray.GetLength(1); j++) {
                if (j < rectangularArray.GetLength(1) - 1) {
                    Console.Write(rectangularArray[i, j] + " ");
                }
                else {
                    Console.Write(rectangularArray[i, j]);
                }
            }
            Console.WriteLine();
        }
    }
}
