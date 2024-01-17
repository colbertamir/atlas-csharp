using System;
using System.Reflection;

/// <summary>
/// Supplies utility methods for working with objects.
/// </summary>
public class Obj
{
    /// <summary>
    /// Prints the names of available properties and methods of an object.
    /// </summary>
    /// <param name="myObj">The object to inspect.</param>
    public static void Print(object myObj)
    {
        if (myObj == null)
        {
            Console.WriteLine("Object is null.");
            return;
        }

        Type objType = myObj.GetType();
        PropertyInfo[] properties = objType.GetProperties();
        MethodInfo[] methods = objType.GetMethods();

        Console.WriteLine($"{objType.Name} Properties:");
        foreach (var property in properties)
        {
            Console.WriteLine($"{property.PropertyType.Name} {property.Name}");
        }

        Console.WriteLine($"\n{objType.Name} Methods:");
        foreach (var method in methods)
        {
            Console.WriteLine($"{method.ReturnType.Name} {method.Name}");
        }
    }
}
