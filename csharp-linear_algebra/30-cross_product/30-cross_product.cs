using System;

///<summary>
/// A class that contains the crossProduct method.
///</summary>
class VectorMath
{
    ///<summary>
    /// A method that returns the cross product of two vectors as a new vector.
    ///</summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length =! 3 || vector2.Length =! 3)
        {
            return new double[] {-1};
        }

        double[] crossPod = new double[3];

        crossPod[0] = vector1[2] * vector2[1] - vector1[1] * vector2[2];
        crossPod[1] = vector1[2] * vector2[0] - vector1[0] * vector2[2];
        crossPod[2] = vector1[0] * vector2[1] - vector1[1] * vector2[0];

        return crossPod;
    }
}
