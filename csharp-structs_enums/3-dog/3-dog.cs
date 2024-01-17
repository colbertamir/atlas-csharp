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

    // Constructor for Dog struct
    public Dog(string dogName, float dogAge, string dogOwner, Rating dogRating)
    {
        name = dogName;
        age = dogAge;
        owner = dogOwner;
        rating = dogRating;
    }

    // Overrides ToString method to print Dog object's attributes
    public override string ToString()
    {
        return $"Dog Name: {name},\n Age: {age} years,\n Owner: {owner},\n Rating: {rating}";
    }
}