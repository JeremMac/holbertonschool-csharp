using System;

    ///<summary>
    /// A class that contains the Magnitude method.
    ///</summary>
    class VectorMath
    {
        ///<summary>
        /// A method that returns the magnitude of 2d and 3d vectors.
        ///</summary>
        public static double Magnitude(double[] vector)
    {
    
        if (vector.Length != 2 && vector.Length != 3)
        {
            return -1;
        }


        double sumOfSquares = 0;
        foreach (double component in vector)
        {
            sumOfSquares += component * component;
        }
        double magnitude = Math.Sqrt(sumOfSquares);


        return Math.Round(magnitude, 2);
    }
    }
