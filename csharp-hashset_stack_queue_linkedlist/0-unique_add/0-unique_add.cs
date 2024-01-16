using System;
using System.Collections.Generic;

class ListUtils
{
    public static int Sum(List<int> myList)
    {
        if (myList == null)
        {
            Console.WriteLine("Input list is null");
            return -1; // Returns -1 to indicate a error
        }

        HashSet<int> uniqueIntegers = new HashSet<int>(myList);

        int sum = 0;
        foreach (int num in uniqueIntegers)
        {
            sum += num;
        }

        return sum;
    }
}