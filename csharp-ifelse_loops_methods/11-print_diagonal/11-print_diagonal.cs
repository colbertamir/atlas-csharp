using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length > 0)
        {
            // Draws diagonal line with backslashes
            for (int i = 0; i < length; i++)
            {
                // Print spaces before the backslash to create the diagonal effect
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("\\");
            }
        }

        // Prints new line
        Console.WriteLine();
    }
}