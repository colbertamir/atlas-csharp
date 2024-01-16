using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.Count == 0)
        {
            return 0; // Returns 0 if list is empty
        }

        int headValue = myLList.First.Value; // Get the value of the head node
        myLList.RemoveFirst(); // Removes head node

        return headValue; // Returns the value of the removed head node
    }
}