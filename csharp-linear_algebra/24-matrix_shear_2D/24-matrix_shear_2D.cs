using System;

/// <summary>
/// A class that contains the Shear2D method
/// </summary>
class MatrixMath
{
    
    /// <summary>
    /// A method that shears a 2D matrix with a given factor.
    /// </summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (direction != 'x' && direction != 'y')
        {
            return new double[,] {{-1}};
        }

        if (matrix.GetLength(0) != 2)
        {
            return new double[,] {{-1}};
        }

        double[,] result = new double[2, 2];

        int row = matrix.GetLength(0);

        if (direction == 'x')
        {
            for (int i = 0; i < row; i++)
            {
                result[i, 0] = matrix[i, 0] + factor * matrix[i, 1];
                result[i, 1] = matrix[i, 1];
            }
        }

        else if(direction == 'y')
        {
            for (int i = 0; i < row; i++)
            {
                result[i, 0] = matrix[i, 0];
                result[i, 1] = matrix[i, 1] + factor * matrix[i, 0] 
            }
        }
        return result;
    }
}
