using System;

class ExceptionDemo
{
    public static void Throw()
    {
        // Throws a custom exception
        throw new ApplicationException("Custom exception.");
    }
}