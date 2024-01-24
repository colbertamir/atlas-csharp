using System;

/// <summary>
/// Provides matrix-related mathematical operations.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Rotates a square 2D matrix by a given angle in radians and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix">The square 2D matrix represented as a 2D array of doubles.</param>
    /// <param name="angle">The angle in radians by which to rotate the matrix.</param>
    /// <returns>The matrix resulting from rotating the input matrix by the specified angle.</returns>
    /// <remarks>
    /// If the matrix is of an invalid size (non-square), returns a matrix containing -1.
    /// </remarks>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Check if the matrix is square
        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
        {
            // If the matrix is of an invalid size (non-square), return a matrix containing -1
            return new double[,] { { -1 } };
        }

        int size = matrix.GetLength(0);
        double[,] result = new double[size, size];

        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                // Apply rotation to each element in the matrix
                double x = i - size / 2.0;
                double y = j - size / 2.0;

                double rotatedX = cosTheta * x - sinTheta * y + size / 2.0;
                double rotatedY = sinTheta * x + cosTheta * y + size / 2.0;

                // Round the result to the nearest hundredth
                result[i, j] = Math.Round(GetInterpolatedValue(matrix, rotatedX, rotatedY), 2);
            }
        }

        return result;
    }
}