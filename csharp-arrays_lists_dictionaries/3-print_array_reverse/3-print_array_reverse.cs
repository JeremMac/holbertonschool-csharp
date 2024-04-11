using System;

class Array {
    public static void Reverse(int[] array) {
        if (array != null) {
            int reverse;
            for (reverse = array.Length - 1; reverse >= 0; reverse--) {
                if (reverse > 0) {
                    Console.Write("{0} ", array[reverse]);
                }
                else {
                    Console.Write("{0}", array[reverse]);
                }
            }
        }
        Console.WriteLine();
    }
}
