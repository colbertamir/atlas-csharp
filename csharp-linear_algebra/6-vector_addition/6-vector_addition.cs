using System;

/// <summary>
/// Provides vector-related mathematical operations.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Adds two vectors and returns resulting vector.
    /// </summary>
    /// <param name="vector1">The first vector represented as an array of doubles.</param>
    /// <param name="vector2">The second vector represented as an array of doubles.</param>
    /// <returns>The resulting vector obtained by adding vector1 and vector2.</returns>
    /// <remarks>
    /// If any vector is not 2D or 3D, or if the vectors aren't of the same size, returns a vector containing -1.
    /// </remarks>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1 == null || vector2 == null ||
            (vector1.Length != 2 && vector1.Length != 3) ||
            (vector2.Length != 2 && vector2.Length != 3) ||
            vector1.Length != vector2.Length)
        {
            // If any vector is not 2D or 3D, or if the vectors aren't the same size, return vector containing -1
            return new double[] { -1 };
        }

        // Initialize the result vector
        double[] result = new double[vector1.Length];

        // Perform vector addition
        for (int i = 0; i < vector1.Length; i++)
        {
            result[i] = vector1[i] + vector2[i];
        }

        return result;
    }
}