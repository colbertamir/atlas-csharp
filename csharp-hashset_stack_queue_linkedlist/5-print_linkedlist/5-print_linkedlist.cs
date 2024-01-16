using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> newList = new LinkedList<int>();

        if (size < 0)
        {
            return newList;
        }

        for (int i = 0; i < size; i++)
        {
            newList.AddLast(i);
        }

        // Prints created list
        Console.WriteLine("Linked List:");
        foreach (int item in newList)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine(); // Adds a new line after printing the list

        return newList;
    }
}