using System;

public class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if the matrix is empty
        if (rows == 0 || cols == 0)
        {
            return new double[0, 0];
        }

        // Create a new matrix to hold the transposed values
        double[,] transposed = new double[cols, rows];

        // Transpose the matrix
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposed[j, i] = matrix[i, j];
            }
        }

        return transposed;
    }
}
