using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int index = 0;
        LinkedListNode<int> currentNode = myLList.First;

        while (currentNode != null)
        {
            if (currentNode.Value == value)
            {
                return index; // Returns index if the value is found
            }

            currentNode = currentNode.Next;
            index++;
        }

        return -1; // Returns -1 if the value is not found
    }
}