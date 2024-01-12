using System;

class Program
{
    static void Main()
    {
        char currentChar = 'a';

        for (int i = 0; i < 26; i++)
        {
            if (currentChar != 'e' && currentChar != 'q')
            {
                Console.Write(currentChar);
            }
            currentChar++;
        }
    }
}
