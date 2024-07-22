using System;

/// <summary>
/// A class that contains the CheckType methode.
/// </summary>
/// <typeparam name="T"></typeparam>
public class Queue<T>
{
    /// <summary>
    /// a methode that returns the Queue’s type.
    /// </summary>
    /// <returns> the name of the type </returns>
    public string CheckType()
    {
        return typeof(T).FullName;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Queue<string> myStrQ = new Queue<string>();
        Queue<object> myObjQ = new Queue<object>();

        Console.WriteLine($"{nameof(myStrQ)} Queue Type: " + myStrQ.CheckType());
        Console.WriteLine($"{nameof(myObjQ)} Queue Type: " + myObjQ.CheckType());
    }
}