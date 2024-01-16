using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        // Add a node to the beginning of the linked list
        LinkedListNode<int> newNode = myLList.AddFirst(n);

        return newNode;
    }
}