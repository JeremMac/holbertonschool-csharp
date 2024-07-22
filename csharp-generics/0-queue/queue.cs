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
    public Type CheckType()
    {
        return typeof(T);
    }
}
