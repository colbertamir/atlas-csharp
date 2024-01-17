using System;

// Defines Rating enum
enum Rating
{
    Good,
    Great,
    Excellent
}

class Program
{
    static void Main(string[] args)
    {
        Rating rating;

        rating = Rating.Great;

        Console.WriteLine("Score: " + rating);
        Console.WriteLine("Score: " + (int)rating);
    }
}
