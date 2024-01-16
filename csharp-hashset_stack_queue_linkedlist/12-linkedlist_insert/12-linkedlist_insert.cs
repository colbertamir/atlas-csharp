using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        // Creates a new node with the specified value
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);

        // If the list is empty or the new node value is less than the head value
        if (myLList.First == null || n < myLList.First.Value)
        {
            // Inserts new node at the beginning
            myLList.AddFirst(newNode);
            return newNode;
        }

        // Iterate through the list to find the correct position to insert the new node
        LinkedListNode<int> current = myLList.First;
        while (current.Next != null && n >= current.Next.Value)
        {
            current = current.Next;
        }

        // Inserts the new node after the current node
        myLList.AddAfter(current, newNode);
        return newNode;
    }
}