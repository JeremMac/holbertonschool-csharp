using System;

/// <summary>
/// A class that contains the Multiply method.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// A method that multiplies two matrix.
    /// </summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int rowsMatrix1 = matrix1.GetLength(0);
        int colsMatrix1 = matrix1.GetLength(1);
        int rowsMatrix2 = matrix2.GetLength(0);
        int colsMatrix2 = matrix2.GetLength(1);

        // Check if matrices can be multiplied
        if (colsMatrix1 != rowsMatrix2)
        {
            return new double[,] { { -1 } };
        }

        // Create the result matrix
        double[,] result = new double[rowsMatrix1, colsMatrix2];

        // Perform matrix multiplication
        for (int i = 0; i < rowsMatrix1; i++)
        {
            for (int j = 0; j < colsMatrix2; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < colsMatrix1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }
}
