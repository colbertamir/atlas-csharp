/// <summary>
/// Represents a player with health-related properties and methods.
/// </summary>
public class Player
{
    /// <summary>
    /// Gets the name of the player.
    /// </summary>
    public string Name
    {
        get { return name; }
    }

    /// <summary>
    /// Gets the maximum health points of the player.
    /// </summary>
    public float MaxHp
    {
        get { return maxHp; }
    }

    /// <summary>
    /// Gets the current health points of the player.
    /// </summary>
    public float Hp
    {
        get { return hp; }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Player"/> class.
    /// </summary>
    /// <param name="name">The name of the player. Default is "Player".</param>
    /// <param name="maxHp">The maximum health points. Default is 100f.</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        // Check if maxHp is greater than 0
        if (maxHp > 0)
        {
            this.name = name;
            this.maxHp = maxHp;
            this.hp = maxHp;
        }
        else
        {
            // Set maxHp to the default value of 100f
            this.maxHp = 100f;
            this.hp = this.maxHp;

            // Print message
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
    }

    /// <summary>
    /// Prints the health information of the player to the console.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    // Private fields
    private string name;
    private float maxHp;
    private float hp;
}
