using System;
using System.Collections.Generic;

class DictionaryUtils
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        if (myDict == null)
        {
            Console.WriteLine("Dictionary is null");
            return -1;
        }

        int keyCount = 0;

        foreach (var keyValuePair in myDict)
        {

            keyCount++;
        }

        return keyCount;
    }
}