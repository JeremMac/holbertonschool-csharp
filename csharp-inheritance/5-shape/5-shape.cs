using System;

///<summary>
/// A class that contains the Area method.
///</summary>
class Shape
{

    ///<summary>
    /// A method that throws an error message.
    ///</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
