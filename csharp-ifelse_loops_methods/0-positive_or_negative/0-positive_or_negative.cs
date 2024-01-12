using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10, 10);

        Console.Write($"The number {number} is ");

        if (number > 0)
        {
            Console.WriteLine("positive");
        }
        else if (number == 0)
        {
            Console.WriteLine("zero");
        }
        else
        {
            Console.WriteLine("negative");
        }
    }
}
