using System;
using System.Collections.Generic;
using System.Reflection;


///<summary>
/// A class that contains the Print method.
///</summary>
class Obj
{

    ///<summary>
    /// A method that print the methods and properties of an object.
    ///</summary>
    public static void Print(object myObj)
    {
        Type type = myObj.GetType();

        Console.WriteLine($"{type.Name} Properties:");
        foreach (PropertyInfo  properties in type.GetProperties())
        {
            Console.WriteLine(properties.Name);
        }

        Console.WriteLine($"{type.Name} Methods:");
        foreach (MethodInfo methods in type.GetMethods())
        {
            Console.WriteLine(methods.Name);
        }
    }
}
