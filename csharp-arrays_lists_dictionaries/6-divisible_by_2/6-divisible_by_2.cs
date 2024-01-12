using System;
using System.Collections.Generic;

class ListUtils
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        if (myList == null)
        {
            Console.WriteLine("List is null");
            return null;
        }

        List<bool> result = new List<bool>(myList.Count);

        foreach (int number in myList)
        {
            result.Add(number % 2 == 0);
        }

        return result;
    }
}