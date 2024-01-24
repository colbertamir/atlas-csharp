using System;

/// <summary>
/// Provides vector-related mathematical operations.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Calculates and returns the magnitude of a 2D or 3D vector.
    /// </summary>
    /// <param name="vector">The vector represented as an array of doubles.</param>
    /// <returns>The magnitude of the vector rounded to nearest hundredth.</returns>
    /// <remarks>If the vector is not 2D or 3D, returns -1.</remarks>
    public static double Magnitude(double[] vector)
    {
        if (vector == null || (vector.Length != 2 && vector.Length != 3))
        {
            // If the vector isn't 2D or 3D, return -1
            return -1;
        }

        double sumOfSquares = 0;

        // Calculate sum of squares for each component
        foreach (double component in vector)
        {
            sumOfSquares += Math.Pow(component, 2);
        }

        // Calculate the magnitude and round to the nearest hundredth
        double magnitude = Math.Sqrt(sumOfSquares);
        return Math.Round(magnitude, 2);
    }
}