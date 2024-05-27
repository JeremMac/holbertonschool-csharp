using System;

    class VectorMath
    {
        public static double Magnitude(double[] vector)
        {
            public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2)
        {
            // Vecteur 2D
            return Math.Round(Math.Sqrt(vector[0] * vector[0] + vector[1] * vector[1]), 2);
        }
        else if (vector.Length == 3)
        {
            // Vecteur 3D
            return Math.Round(Math.Sqrt(vector[0] * vector[0] + vector[1] * vector[1] + vector[2] * vector[2]), 2);
        }
        else
        {
            // Vecteur non valide
            return -1;
        }
    }
        }
    }
