using System;

/// <summary>
/// 
/// </summary>
class MatrixMath
{
    /// <summary>
    /// 
    /// </summary>
    public static double[,] Transpose(double[,] matrix)
    {
        // Obtenir les dimensions de la matrice
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        if (rows == 0 && cols == 0)
        {
            return new double[,] {{}};
        }

        // Créer la matrice transposée
        double[,] transposedMatrix = new double[cols, rows];

        // Remplir la matrice transposée
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposedMatrix[j, i] = matrix[i, j];
            }
        }

        return transposedMatrix;
    }
}
