using System;

/// <summary>
/// Provides vector-related mathematical operations.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Multiplies a vector by a scalar and returns resulting vector.
    /// </summary>
    /// <param name="vector">The vector represented as an array of doubles.</param>
    /// <param name="scalar">The scalar value to multiply the vector by.</param>
    /// <returns>The resulting vector is obtained by multiplying the vector by the scalar.</returns>
    /// <remarks>
    /// If the vector is not 2D or 3D, returns a vector containing -1.
    /// </remarks>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector == null || (vector.Length != 2 && vector.Length != 3))
        {
            // If the vector is not 2D or 3D, return a vector containing -1
            return new double[] { -1 };
        }

        // Initialize the result vector
        double[] result = new double[vector.Length];

        // Perform vector-scalar multiplication
        for (int i = 0; i < vector.Length; i++)
        {
            result[i] = vector[i] * scalar;
        }

        return result;
    }
}
