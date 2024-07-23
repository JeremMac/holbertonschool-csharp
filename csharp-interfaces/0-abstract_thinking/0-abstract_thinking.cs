using System;

/// <summary>
/// An abstract class that contains the name property.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// A public string.
    /// </summary>
    public string name;

    /// <summary>
    /// Overiden ToString methode.
    /// </summary>
    /// <returns>A caracter string</returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}
