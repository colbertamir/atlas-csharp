using System;

class Except
{
    public static void ThrowMsg(string msg)
    {
        // Throws an exception with a message
        throw new Exception(msg);
    }
}