using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        // Check if the requested index is within the valid range
        if (n < 0 || n >= myLList.Count)
        {
            return 0; // Returns 0 if node doesn't exist
        }

        // Traverse linked list to the nth node
        LinkedListNode<int> currentNode = myLList.First;
        for (int i = 0; i < n; i++)
        {
            currentNode = currentNode.Next;
        }

        // Returns value of the nth node
        return currentNode.Value;
    }
}