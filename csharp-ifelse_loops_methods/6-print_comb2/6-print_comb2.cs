using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = i + 1; j < 10; j++)
            {
                Console.Write($"{i}{j}{(i == 8 && j == 9 ? "\n" : ", ")}");
            }
        }
    }
}
