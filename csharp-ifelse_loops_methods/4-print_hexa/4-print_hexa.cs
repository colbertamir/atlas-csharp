using System;

using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 99; i++)
        {
            Console.Write($"{i} {i.ToString("X")}{(i < 98 ? ", " : "")}");
        }
    }
}
