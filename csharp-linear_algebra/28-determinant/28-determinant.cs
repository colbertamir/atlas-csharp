public class MatrixMath
{
    public static double Determinant(double[,] matrix)
    {
        // Check if the matrix is square (i.e., number of rows equals number of columns)
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols || (rows != 2 && rows != 3))
        {
            // Matrix is not 2D or 3D, return -1
            return -1;
        }

        // For a 2x2 matrix
        if (rows == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }

        // For a 3x3 matrix
        if (rows == 3)
        {
            return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
                - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
                + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
        }

        return -1; // Default case, should not reach here
    }
}
