using System;

/// <summary>
/// Provides matrix-related mathematical operations.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Multiplies two matrices and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix1">The first matrix represented as a 2D array of doubles.</param>
    /// <param name="matrix2">The second matrix represented as a 2D array of doubles.</param>
    /// <returns>The matrix resulting from the multiplication of matrix1 by matrix2.</returns>
    /// <remarks>
    /// The matrices will not necessarily be square or the same dimensions.
    /// If the matrices can't be multiplied, returns a matrix containing -1.
    /// </remarks>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1 == null || matrix2 == null || matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            // If matrices can't be multiplied, return a matrix containing -1
            return new double[,] { { -1 } };
        }

        // Initialize the result matrix
        double[,] result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        // Perform matrix multiplication
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }
}