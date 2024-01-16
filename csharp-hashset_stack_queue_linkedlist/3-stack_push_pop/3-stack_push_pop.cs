using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Prints number of items in aStack
        Console.WriteLine($"Number of items: {aStack.Count}");

        // Prints the item at the top of aStack without removing it
        if (aStack.Count > 0)
        {
            Console.WriteLine($"Top item: {aStack.Peek()}");
        }
        else
        {
            Console.WriteLine("Stack is empty");
        }

        // Prints if aStack contains a given item search
        Console.WriteLine($"Stack contains {search}: {aStack.Contains(search)}");

        // If aStack contains the given item search, remove all items up to & including search
        if (aStack.Contains(search))
        {
            while (aStack.Count > 0 && aStack.Peek() != search)
            {
                aStack.Pop();
            }
            // Remove the found item
            if (aStack.Count > 0)
            {
                aStack.Pop();
            }
        }

        // Add a given item newItem to aStack
        aStack.Push(newItem);

        return aStack;
    }
}