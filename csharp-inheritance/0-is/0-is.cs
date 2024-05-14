using System;
using System.Collections.Generic;


///<summary>
/// A class that contains IsOfTypeInt method.
///</summary>
class Obj
{
    ///<summary>
    /// A method that return true if obj is an int, otherwise return false.
    ///</summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
        {
            return true;
        }
        return false;
    }
}
