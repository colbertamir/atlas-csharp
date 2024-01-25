/// <summary>
/// A class containing methods for matrix operations.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Calculates the inverse of a 2D matrix.
    /// </summary>
    /// <param name="matrix">The input 2D matrix.</param>
    /// <returns>
    /// The resulting inverse matrix. 
    /// If the input is not a 2D matrix or the matrix is non-invertible, returns a matrix containing -1.
    /// </returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        // Check if the matrix is a 2D matrix
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != 2 || cols != 2)
        {
            // Matrix is not a 2D matrix, return a matrix containing -1
            return new double[,] { { -1 } };
        }

        // Calculate the determinant
        double determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        if (determinant == 0)
        {
            // Matrix is non-invertible, return a matrix containing -1
            return new double[,] { { -1 } };
        }

        // Calculate the inverse matrix
        double[,] inverseMatrix = new double[2, 2];
        inverseMatrix[0, 0] = matrix[1, 1] / determinant;
        inverseMatrix[0, 1] = -matrix[0, 1] / determinant;
        inverseMatrix[1, 0] = -matrix[1, 0] / determinant;
        inverseMatrix[1, 1] = matrix[0, 0] / determinant;

        return inverseMatrix;
    }
}
