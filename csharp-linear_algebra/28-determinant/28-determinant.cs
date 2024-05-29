using System;

/// <summary>
/// A class that contains the Determinant method.
/// </summary>
public static class MatrixMath
{
    /// <summary>
    /// A method that returns the determinant of a matrix.
    /// </summary>
    public static double Determinant(double[,] matrix)
    {
        if (rows != 2 && rows != 3)
        {
            return -1;
        }

        // Vérifier que la matrice est 2D ou 3D
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Calculer le déterminant en fonction de la taille de la matrice
        if (rows == 2)
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        else if (rows == 3)
            return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
                 - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
                 + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
    }
}
