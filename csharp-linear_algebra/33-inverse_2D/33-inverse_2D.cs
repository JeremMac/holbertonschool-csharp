using System;

///<summary>
/// A class that contains the Inverse2D method.
///</summary>
class MatrixMath
{
    ///<summary>
    /// A method that returns an inversed matrix.
    ///</summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return new double [,] {{-1}};
        }

        double determinant = matrix[0,0] * matrix[1,1] - matrix[1,0] * matrix[0,1];

        if (determinant == 0)
        {
            return new double [,] {{-1}};
        }

        double[,] invertedMat = new double[2,2];

        invertedMat[0,0] = Math.Round(matrix[1,1] / determinant, 2);
        invertedMat[1,0] = Math.Round((-matrix[1,0]) / determinant, 2);
        invertedMat[0,1] = Math.Round((-matrix[0,1]) / determinant, 2);
        invertedMat[1,1] = Math.Round(matrix[0,0] / determinant, 2);

        return invertedMat;
    }
}
