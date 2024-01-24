using System;

/// <summary>
/// Provides vector-related mathematical operations.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Calculates the dot product of either two 2D or two 3D vectors.
    /// </summary>
    /// <param name="vector1">The first vector represented as an array of doubles.</param>
    /// <param name="vector2">The second vector represented as an array of doubles.</param>
    /// <returns>The dot product of the two vectors.</returns>
    /// <remarks>
    /// If any vector is not 2D or 3D, or both vectors are not the same size, returns -1.
    /// </remarks>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1 == null || vector2 == null ||
            (vector1.Length != 2 && vector1.Length != 3) ||
            (vector2.Length != 2 && vector2.Length != 3) ||
            vector1.Length != vector2.Length)
        {
            // If any vector is not 2D or 3D, or both vectors aren't the same size, return -1
            return -1;
        }

        // Initialize result
        double result = 0;

        // Perform dot product calculation
        for (int i = 0; i < vector1.Length; i++)
        {
            result += vector1[i] * vector2[i];
        }

        return result;
    }
}