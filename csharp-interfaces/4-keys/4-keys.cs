using System;

/// <summary>
/// Represents an interface for interactive objects.
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Performs an interaction with the object.
    /// </summary>
    void Interact();
}

/// <summary>
/// Represents an interface for breakable objects.
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// Gets or sets the durability of the object.
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Breaks the object.
    /// </summary>
    void Break();
}

/// <summary>
/// Represents an interface for collectable objects.
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// Gets or sets whether the object has been collected.
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Collects the object.
    /// </summary>
    void Collect();
}

/// <summary>
/// Represents an abstract base class.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Gets or sets the name of the object.
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Returns a string representation of the object.
    /// </summary>
    /// <returns>A formatted string representing the object.</returns>
    public override string ToString()
    {
        return $"{name} is a {GetType().ToString()}";
    }
}

/// <summary>
/// Represents a class that inherits from Base, IInteractive, and IBreakable.
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    private int _durability; // Private field to store the durability value

    /// <summary>
    /// Initializes a new instance of the Decoration class.
    /// If name isn't provided, the default value is set to Decoration.
    /// If durability isn't provided, default value is 1.
    /// If isQuestItem isn't provided, default value is false.
    /// </summary>
    /// <param name="name">The name of decoration.</param>
    /// <param name="durability">The durability of decoration.</param>
    /// <param name="isQuestItem">Whether the decoration is a quest item.</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new ArgumentException("Durability must be greater than 0");
        }

        this.name = name;
        this._durability = durability; // Initialize the private field
        this.isQuestItem = isQuestItem;
    }

    // Implementation of IInteractive
    /// <summary>
    /// Performs interaction with decoration.
    /// </summary>
    public void Interact()
    {
        if (_durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    // Implementation of IBreakable
    /// <summary>
    /// Gets or sets the durability of the decoration.
    /// </summary>
    public int durability
    {
        get { return _durability; }
        set { _durability = value; }
    }

    /// <summary>
    /// Breaks the decoration.
    /// </summary>
    public void Break()
    {
        _durability--;

        if (_durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if (_durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }

    /// <summary>
    /// Gets or sets whether the decoration is a quest item.
    /// </summary>
    public bool isQuestItem { get; set; }
}

/// <summary>
/// Represents a class that inherits from Base and ICollectable.
/// </summary>
public class Key : Base, ICollectable
{
    /// <summary>
    /// Initializes a new instance of the Key class.
    /// If name isn't provided, the default value is set to Key.
    /// If isCollected isn't provided, the default value is false.
    /// </summary>
    /// <param name="name">The name of key.</param>
    /// <param name="isCollected">Whether the key has been collected.</param>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    // Implementation of ICollectable
    /// <summary>
    /// Collects key.
    /// </summary>
    public void Collect()
    {
        if (!isCollected)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }

    /// <summary>
    /// Gets or sets whether the key has been collected.
    /// </summary>
    public bool isCollected { get; set; }
}
