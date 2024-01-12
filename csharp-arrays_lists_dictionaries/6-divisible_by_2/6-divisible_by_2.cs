using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        if (numbers == null)
        {
            Console.WriteLine("Input list is null");
            return null;
        }

        List<bool> result = new List<bool>(numbers.Count);

        foreach (int number in numbers)
        {
            result.Add(number % 2 == 0);
        }

        return result;
    }
}