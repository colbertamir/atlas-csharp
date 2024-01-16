using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int count = 0;

        // Traverse the linked list and count the elements
        foreach (int item in myLList)
        {
            count++;
        }

        return count;
    }
}