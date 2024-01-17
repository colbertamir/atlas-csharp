using System;
using System.Collections.Generic;

class ListUtils
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();

        try
        {
            for (int i = 0; i < listLength; i++)
            {
                // Attempt to perform the division
                int numerator = i < list1.Count ? list1[i] : 0;
                int denominator = i < list2.Count ? list2[i] : 1;

                int divisionResult = numerator / denominator;
                result.Add(divisionResult);
            }
        }
        catch (DivideByZeroException)
        {
            // Handles case where division by zero occurs
            Console.WriteLine("Cannot divide by zero");
            return new List<int>();
        }
        catch (ArgumentOutOfRangeException)
        {
            // Handles case where either list is too short
            Console.WriteLine("Out of range");
            return new List<int>();
        }

        return result;
    }
}