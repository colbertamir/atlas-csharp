using System;

/// <summary>
/// Provides matrix-related mathematical operations.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Adds two matrices and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix1">The first matrix represented as a 2D array of doubles.</param>
    /// <param name="matrix2">The second matrix represented as a 2D array of doubles.</param>
    /// <returns>The matrix resulting from the addition of the two matrices.</returns>
    /// <remarks>
    /// The matrices can be either both 2D or both 3D.
    /// If any matrix is not 2D or 3D, or both matrices aren't the same size, returns a matrix containing -1.
    /// </remarks>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1 == null || matrix2 == null ||
            (matrix1.GetLength(0) != matrix2.GetLength(0)) ||
            (matrix1.GetLength(1) != matrix2.GetLength(1)) ||
            (matrix1.GetLength(0) != 2 && matrix1.GetLength(0) != 3) ||
            (matrix2.GetLength(0) != 2 && matrix2.GetLength(0) != 3))
        {
            // If any matrix is not 2D or 3D, or both matrices aren't the same size, return a matrix containing -1
            return new double[,] { { -1 } };
        }

        // Initialize the result matrix
        double[,] result = new double[matrix1.GetLength(0), matrix1.GetLength(1)];

        // Perform matrix addition
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }
}
