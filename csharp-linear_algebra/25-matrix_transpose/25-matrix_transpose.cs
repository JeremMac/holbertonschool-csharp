﻿using System;

public static class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
        // Vérifier si la matrice est vide
        if (matrix.Length == 0)
            return new double[0, 0];

        // Obtenir les dimensions de la matrice
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

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
