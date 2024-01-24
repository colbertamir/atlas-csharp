using System;

/// <summary>
/// Provides matrix-related mathematical operations.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Shears a square 2D matrix by a given shear factor and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix">The square 2D matrix represented as a 2D array of doubles.</param>
    /// <param name="direction">The direction of the shear (either 'x' or 'y').</param>
    /// <param name="factor">The shear factor to apply.</param>
    /// <returns>The matrix resulting from shearing the input matrix in the specified direction with the given factor.</returns>
    /// <remarks>
    /// If the matrix is of an invalid size (non-square) or if the given direction is not 'x' or 'y', returns a matrix containing -1.
    /// </remarks>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        // Check if the matrix is square
        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
        {
            // If the matrix is of an invalid size (non-square), return a matrix containing -1
            return new double[,] { { -1 } };
        }

        // Check if the direction is either 'x' or 'y'
        if (direction != 'x' && direction != 'y')
        {
            // If the given direction is not 'x' or 'y', return a matrix containing -1
            return new double[,] { { -1 } };
        }

        int size = matrix.GetLength(0);
        double[,] result = new double[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (direction == 'x')
                {
                    // Apply shear in the X direction
                    result[i, j] = matrix[i, j + (int)(factor * i)];
                }
                else
                {
                    // Apply shear in the Y direction
                    result[i, j] = matrix[i + (int)(factor * j), j];
                }
            }
        }

        return result;
    }
}