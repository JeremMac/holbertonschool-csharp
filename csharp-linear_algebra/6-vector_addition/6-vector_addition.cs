using System;

    /// <summary>
    /// A class that contains the Add method.
    /// </summary>
    class VectorMath
    {
        /// <summary>
        /// A method that adds two vectors.
        /// </summary>
        public static double[] Add(double[] vector1, double[] vector2)
        {
            if ((vector1.Length != 2 && vector1.Length != 3) || 
                (vector2.Length != 2 && vector2.Length != 3))
            {
                return new double[] { -1 };
            }

            if (vector1.Length != vector2.Length)
            {
                return new double[] { -1 };
            }

            double[] newVector = new double[vector1.Length];
            for (int i = 0; i < vector1.Length; i++)
            {
                newVector[i] = vector1[i] + vector2[i];
            }
            return newVector;
        }
    }
