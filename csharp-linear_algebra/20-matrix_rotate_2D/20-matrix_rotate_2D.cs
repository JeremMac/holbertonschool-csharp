using System;

/// <summary>
/// A class that contains the Rotate2D method.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// A method that rotates a matrix.
    /// </summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if the matrix is square
        if (rows != cols)
        {
            return new double[,] { { -1 } };
        }

        // Calculate the rotation matrix elements
        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);

        // Initialize the result matrix
        double[,] result = new double[rows, cols];

        // Apply rotation to each element in the matrix
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                double x = matrix[i, j];
                double y = matrix[j, i];

                result[i, j] = x * cosTheta - y * sinTheta;
                result[j, i] = x * sinTheta + y * cosTheta;
            }
        }

        return result;
    }
}
