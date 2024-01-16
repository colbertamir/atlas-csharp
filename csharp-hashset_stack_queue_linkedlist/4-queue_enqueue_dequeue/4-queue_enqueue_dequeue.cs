using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        // Prints number of items in aQueue
        Console.WriteLine($"Number of items: {aQueue.Count}");

        // Print the item at the top of aQueue without removing it
        if (aQueue.Count > 0)
        {
            Console.WriteLine($"First item: {aQueue.Peek()}");
        }
        else
        {
            Console.WriteLine("Queue is empty");
        }

        // Adds a new given item newItem to aQueue
        aQueue.Enqueue(newItem);

        // Prints if aQueue has a given item search
        Console.WriteLine($"Queue contains {search}: {aQueue.Contains(search)}");

        // If aQueue contains the given item search, remove all items up to & including search
        if (aQueue.Contains(search))
        {
            while (aQueue.Count > 0 && aQueue.Peek() != search)
            {
                aQueue.Dequeue();
            }
            // Removes found item
            if (aQueue.Count > 0)
            {
                aQueue.Dequeue();
            }
        }

        return aQueue;
    }
}