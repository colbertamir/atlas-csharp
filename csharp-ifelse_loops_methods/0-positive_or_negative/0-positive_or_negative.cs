using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10, 10);

        // Print the number
        Console.WriteLine($"The number is: {number}");

        // Check if the number is positive, zero, or negative
        if (number > 0)
        {
            Console.WriteLine("is positive");
        }
        else if (number == 0)
        {
            Console.WriteLine("is zero");
        }
        else
        {
            Console.WriteLine("is negative");
        }
    }
}
