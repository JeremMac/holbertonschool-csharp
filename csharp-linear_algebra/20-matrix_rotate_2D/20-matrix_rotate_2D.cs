﻿using System;

/// <summary>
/// A class that contains the Rotate2D method.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// A method that Rotate a 2D matrix.
    /// </summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != 2 || cols != 2)
        {
            return new double[,] { { -1 } };
        }

        double[,] Radians = {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}};
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                for (int k = 0; k < cols; k++)
                {
                    result[i, j] += Math.Round(matrix[i, k] * Radians[k, j], 2);
                }
            }
        }

        return result;
    }
}
