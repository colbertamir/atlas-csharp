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
/// Represents a class that inherits from Base and implements IInteractive, IBreakable, and ICollectable.
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    // Implementation of IInteractive
    /// <summary>
    /// Performs an interaction with the object.
    /// </summary>
    public void Interact()
    {
        // Implementation goes here
    }

    // Implementation of IBreakable
    /// <summary>
    /// Gets or sets the durability of the object.
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Breaks object.
    /// </summary>
    public void Break()
    {
        // Implementation goes here
    }

    // Implementation of ICollectable
    /// <summary>
    /// Gets or sets whether the object has been collected.
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Collects object.
    /// </summary>
    public void Collect()
    {
        // Implementation goes here
    }
}
