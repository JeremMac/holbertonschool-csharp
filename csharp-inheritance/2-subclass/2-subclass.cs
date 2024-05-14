using System;


///<summary>
/// A class that contains the IsOnlyASubclass method.
///</summary>
class Obj
{

    ///<summary>
    /// A method that returns True if the object is an instance of a class that inherits from the specified class, otherwise return False.
    ///</summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
        {
            return true;
        }
        return false;
    }
}
