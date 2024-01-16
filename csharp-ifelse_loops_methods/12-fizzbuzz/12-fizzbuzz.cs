using System;

class FizzBuzzProgram
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            // Checks for multiples of both three and five first
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write("FizzBuzz");
            }
            // Checks for multiples of three
            else if (i % 3 == 0)
            {
                Console.Write("Fizz");
            }
            // Checks for multiples of five
            else if (i % 5 == 0)
            {
                Console.Write("Buzz");
            }
            // Prints number for other cases
            else
            {
                Console.Write(i);
            }

            // Prints a space after each element
            Console.Write(" ");
        }

        // Prints a new line at the end
        Console.WriteLine();
    }
}
