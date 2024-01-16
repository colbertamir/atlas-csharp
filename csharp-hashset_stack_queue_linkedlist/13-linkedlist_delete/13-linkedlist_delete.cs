using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        // Checks if index is valid
        if (index < 0 || index >= myLList.Count)
        {
            Console.WriteLine("Invalid index. Node not deleted.");
            return;
        }

        // Find the node at the specified index
        LinkedListNode<int> nodeToDelete = myLList.First;
        for (int i = 0; i < index; i++)
        {
            nodeToDelete = nodeToDelete.Next;
        }

        // Removes node from the linked list
        myLList.Remove(nodeToDelete);
    }
}