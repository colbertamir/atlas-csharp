using System;

class Line
{
    public static void PrintLine(int length)
    {
        if (length > 0)
        {
            // Draws the line with underscores
            for (int i = 0; i < length; i++)
            {
                Console.Write("_");
            }
        }

        // Prints new line
        Console.WriteLine();
    }
}