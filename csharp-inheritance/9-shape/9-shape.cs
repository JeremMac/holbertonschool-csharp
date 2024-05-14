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

    ///<summary>
    /// A method that returns the area of Rectangle.
    ///</summary>
    public override int Area()
    {
        return width * height;
    }

    ///<summary>
    /// A method that return Rectangle in string format.
    ///</summary>
    public override string ToString()
    {
        return $"[Rectangle] {Width} / {Height}";
    }
}

///<summary>
/// A class that inherit from Rectangle.
///</summary>
class Square : Rectangle
{
    private int size;
    
    public int Size
    {
        get { return size; }
        set {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            size = value;
            Width = value;
            Height = value;
        }
    }

    ///<summary>
    /// A method that return Square in string format.
    ///</summary>
    public override string ToString()
    {
        return $"[Square] {size} / {size}";
    }
}
