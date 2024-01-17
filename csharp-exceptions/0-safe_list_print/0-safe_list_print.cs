using System;
using System.Collections.Generic;

class ListUtils
{
    public static int SafePrint(List<int> myList, int n)
    {
        try
        {
            // Iterates over the list and prints elements up to n
            for (int i = 0; i < n; i++)
            {
                Console.Write(myList[i] + " ");
            }

            // Prints a new line after printing the elements
            Console.WriteLine();

            // Returns actual number of elements printed
            return Math.Min(n, myList.Count);
        }
        catch (ArgumentOutOfRangeException)
        {
            // Handles the case where the index is not in range
            Console.WriteLine("Error: Index is out of range.");
            return 0;
        }
    }
}