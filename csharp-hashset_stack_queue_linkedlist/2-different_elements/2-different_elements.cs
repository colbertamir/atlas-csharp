using System;
using System.Collections.Generic;

class ListUtils
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        if (list1 == null || list2 == null)
        {
            Console.WriteLine("Input lists cannot be null");
            return null;
        }

        list1.Sort();
        list2.Sort();

        List<int> differentElements = new List<int>();

        int i = 0, j = 0;

        while (i < list1.Count && j < list2.Count)
        {
            if (list1[i] == list2[j])
            {
                i++;
                j++;
            }
            else if (list1[i] < list2[j])
            {
                differentElements.Add(list1[i]);
                i++;
            }
            else
            {
                differentElements.Add(list2[j]);
                j++;
            }
        }

        // Add the remaining elements from both lists
        for (; i < list1.Count; i++)
        {
            differentElements.Add(list1[i]);
        }

        for (; j < list2.Count; j++)
        {
            differentElements.Add(list2[j]);
        }

        return differentElements;
    }
}