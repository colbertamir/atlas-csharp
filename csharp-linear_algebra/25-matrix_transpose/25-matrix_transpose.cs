using System;

/// <summary>
/// Provides matrix-related mathematical operations.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Transposes a matrix and returns resulting matrix.
    /// </summary>
    /// <param name="matrix">The matrix represented as a 2D array of doubles.</param>
    /// <returns>The transpose of the input matrix.</returns>
    /// <remarks>
    /// If the matrix is empty, returns empty matrix.
    /// </remarks>
    public static double[,] Transpose(double[,] matrix)
    {
        // Check if the matrix is empty
        if (matrix == null || matrix.Length == 0)
        {
            // If the matrix is empty, return an empty matrix
            return new double[,] { };
        }

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        double[,] result = new double[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[j, i] = matrix[i, j];
            }
        }

        return result;
    }
}