using System;

/// <summary>
/// Represents a shape.
/// </summary>
public class Shape
{
    /// <summary>
    /// Calculates and returns area of the shape.
    /// </summary>
    /// <returns>Area of the shape.</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Represents a rectangle.
/// </summary>
public class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// Gets or sets width of the rectangle.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when the width is negative.</exception>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }

    /// <summary>
    /// Gets or sets height of the rectangle.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when provided height is negative.</exception>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0.");
            }
            height = value;
        }
    }
}