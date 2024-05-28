using System;

/// <summary>
/// A class that contains the MultiplyScalar method.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// A method that returns the scalar multiplication of a matrix.
    /// </summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix == null)
        {
            return new double[,] { { -1 }};
        }
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);

        if ((row != 2 && col != 2)
        || (row != 3 && col !=3))
            {
                return new double[,] { { -1 }};
            }
        
        double[,] result = new double[row, col];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                result[i, j] = matrix[i, j] * scalar;
            }
        }
        return result;
    }
}

