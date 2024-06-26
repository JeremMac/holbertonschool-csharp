﻿using System;

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

///<summary>
/// A class that inherits from Shape.
///</summary>
class Rectangle : Shape
{
    private int width;
    private int height;


    public int Width
    {
        get { return width; }
        set {
                if (value < 0)
                {
                    throw new ArgumentException("Width must be greater than or equal to 0");
                }
                width = value; 
            }
    }

    public int Height
    {
        get { return height; }
        set {
                if (value < 0)
                {
                    throw new ArgumentException("Height must be greater than or equal to 0");
                }
                height = value; 
            }
    }
}
