using System;
using System.Collections.Generic;

///<summary>
/// A class that contains the sInstanceOfArray method.
///</summary>
class Obj
{

    ///<summary>
    /// A method that returns true if obj is an Array or inherits from it. 
    ///</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array)
        {
            return true;
        }
        return false;
    }
}
