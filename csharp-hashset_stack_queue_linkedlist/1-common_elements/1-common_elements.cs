using System;
using System.Collections.Generic;

class ListUtils
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        if (list1 == null || list2 == null)
        {
            Console.WriteLine("Input lists cannot be null");
            return null;
        }

        list1.Sort();
        list2.Sort();

        List<int> commonElements = new List<int>();

        int i = 0, j = 0;

        while (i < list1.Count && j < list2.Count)
        {
            if (list1[i] == list2[j])
            {
                commonElements.Add(list1[i]);
                i++;
                j++;
            }
            else if (list1[i] < list2[j])
            {
                i++;
            }
            else
            {
                j++;
            }
        }

        return commonElements;
    }
}