using System;

/// <summary>
/// A class that contains the Rotate2D method.
/// </summary>
public static class MatrixMath
{
    /// <summary>
    /// A method that Rotate a 2D matrix.
    /// </summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Vérifier que la matrice est carrée
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return new double[,] { { -1 } };

        int n = matrix.GetLength(0);
        double[,] result = new double[n, n];

        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                // Appliquer la rotation à chaque élément de la matrice
                result[i, j] = matrix[i, j] * cos - matrix[i, j] * sin;
            }
        }

        return result;
    }
}
