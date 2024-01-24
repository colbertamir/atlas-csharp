using System;

/// <summary>
/// Provides matrix-related mathematical operations.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Multiplies a matrix by a scalar and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix">The matrix represented as a 2D array of doubles.</param>
    /// <param name="scalar">The scalar value to multiply the matrix by.</param>
    /// <returns>The matrix resulting from multiplication by the scalar.</returns>
    /// <remarks>
    /// The matrix can be either 2D or 3D.
    /// If the matrix isn't 2D or 3D, returns a matrix containing -1.
    /// </remarks>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix == null || (matrix.GetLength(0) != 2 && matrix.GetLength(0) != 3))
        {
            // If the matrix is not 2D or 3D, return a matrix containing -1
            return new double[,] { { -1 } };
        }

        // Initialize result matrix
        double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];

        // Perform matrix multiplication by scalar
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result[i, j] = matrix[i, j] * scalar;
            }
        }

        return result;
    }
}