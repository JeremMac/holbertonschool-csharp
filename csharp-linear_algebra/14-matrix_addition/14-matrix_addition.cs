﻿using System;

/// <summary>
/// A class that contains the Add method.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// A method that Add two matrix.
    /// </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1 == null || matrix2 == null)
        {
            return new double[,] { { -1 } };
        }
        
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        if ((rows1 == 2 && cols1 == 2 && rows2 == 2 && cols2 == 2) ||
            (rows1 == 3 && cols1 == 3 && rows2 == 3 && cols2 == 3))
        {
            double[,] result = new double[rows1, cols1];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }
        else
        {
            return new double[,] { { -1 } };
        }
    }
}
