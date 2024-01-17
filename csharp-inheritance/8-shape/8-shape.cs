using System;

/// <summary>
/// Represents a shape.
/// </summary>
public class Shape
{
    /// <summary>
    /// Calculates and returns the area of the shape.
    /// </summary>
    /// <returns>Area of the shape.</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }

    /// <summary>
    /// Returns a string representation of the shape.
    /// </summary>
    /// <returns>String representation of the shape.</returns>
    public override string ToString()
    {
        return "[Shape]";
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
    /// Gets or sets the width of the rectangle.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when width is negative.</exception>
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
    /// Gets or sets the height of rectangle.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when provided height is negative.</exception>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }

    /// <summary>
    /// Calculates and returns area of the rectangle.
    /// </summary>
    /// <returns>Area of the rectangle.</returns>
    public new int Area()
    {
        return width * height;
    }

    /// <summary>
    /// Returns a string representation of rectangle.
    /// </summary>
    /// <returns>String representation of rectangle.</returns>
    public override string ToString()
    {
        return $"[Rectangle] {width} / {height}";
    }
}

/// <summary>
/// Represents a square.
/// </summary>
public class Square : Rectangle
{
    private int size;

    /// <summary>
    /// Gets or sets the size of square.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when size is negative.</exception>
    public int Size
    {
        get { return size; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            size = value;
            Width = size;
            Height = size;
        }
    }
}
