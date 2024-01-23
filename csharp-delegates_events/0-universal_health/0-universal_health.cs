using System;

/// <summary>
/// Represents a player with health-related properties and methods.
/// </summary>
public class Player
{
    /// <summary>
    /// Gets the name of player.
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Gets the maximum health points (maxHp) of the player.
    /// </summary>
    public float MaxHp { get; private set; }

    /// <summary>
    /// Gets or sets current health points (hp) of the player.
    /// </summary>
    private float Hp { get; set; }

    /// <summary>
    /// Initializes new instance of the <see cref="Player"/> class.
    /// </summary>
    /// <param name="name">The name of the player.</param>
    /// <param name="maxHp">The maximum health points of the player.</param>
    public Player(string name, float maxHp)
    {
        // Assign parameters to properties accordingly
        Name = name ?? ;
        MaxHp = maxHp > 0 ? maxHp : 100f; // Default maxHp: 100f

        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }

        // Set hp to the same value as maxHp
        Hp = MaxHp;
    }

    /// <summary>
    /// Prints the health of player.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{Name} has {Hp} / {MaxHp} health");
    }
}
