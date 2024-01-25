/// <summary>
/// A class containing methods for vector operations.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Calculates the cross product of two 3D vectors.
    /// </summary>
    /// <param name="vector1">The first 3D vector.</param>
    /// <param name="vector2">The second 3D vector.</param>
    /// <returns>
    /// The resulting 3D vector from the cross product. 
    /// If either input vector is not a 3D vector, returns a vector containing -1.
    /// </returns>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        // Check if both vectors are 3D vectors
        if (vector1.Length != 3 || vector2.Length != 3)
        {
            // Either vector is not a 3D vector, return a vector containing -1
            return new double[] { -1, -1, -1 };
        }

        // Calculate the cross product
        double resultX = vector1[1] * vector2[2] - vector1[2] * vector2[1];
        double resultY = vector1[2] * vector2[0] - vector1[0] * vector2[2];
        double resultZ = vector1[0] * vector2[1] - vector1[1] * vector2[0];

        return new double[] { resultX, resultY, resultZ };
    }
}
