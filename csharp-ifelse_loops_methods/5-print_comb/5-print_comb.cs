﻿using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.Write($"{i:D2}{(i < 99 ? ", " : "\n")}");
        }
    }
}
