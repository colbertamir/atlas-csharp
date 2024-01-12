using System;

class Program
{
    static void Main()
    {
        char currentChar = 'a';

        for (int i = 0; i < 26; i++)
        {
            Console.Write(currentChar);
            currentChar++;
        }

        Console.WriteLine();
    }
}
