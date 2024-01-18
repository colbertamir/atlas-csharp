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
/// Represents a class that inherits from Base and implements IInteractive.
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Initializes a new instance of the Door class with the specified name.
    /// If name isn't provided, the default value is set to Door.
    /// </summary>
    /// <param name="name">The name of door.</param>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    // Implementation of IInteractive
    /// <summary>
    /// Performs interaction with the door.
    /// Prints: You try to open the &lt;name&gt;. It's locked.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}
