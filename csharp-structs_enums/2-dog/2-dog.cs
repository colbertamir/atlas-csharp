using System;

// Defines Rating enum
enum Rating
{
    Good,
    Great,
    Excellent
}

// Defines Dog struct with constructor
struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    // A constructor for Dog struct
    public Dog(string dogName, float dogAge, string dogOwner, Rating dogRating)
    {
        name = dogName;
        age = dogAge;
        owner = dogOwner;
        rating = dogRating;
    }
}
