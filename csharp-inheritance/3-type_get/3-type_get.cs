using System;
using System.Collections.Generic;
using System.Reflection;

public class Obj
{
    public static void Print(object myObj)
    {
        if (myObj == null)
        {
            Console.WriteLine("Object is null.");
            return;
        }

        Type objType = myObj.GetType();

        // Filter properties & methods based on specified condition
        PropertyInfo[] properties = objType.GetProperties().Where(p => p.PropertyType == typeof(int)).ToArray();
        MethodInfo[] methods = objType.GetMethods().Where(m => m.ReturnType == typeof(int)).ToArray();

        Console.WriteLine("Int32 Properties:");
        foreach (var property in properties)
        {
            Console.WriteLine($"{property.Name}");
        }

        Console.WriteLine("\nInt32 Methods:");
        foreach (var method in methods)
        {
            Console.WriteLine($"{method.Name}");
        }
    }
}