// File: Point2.cs
using System;

class Point
{
    private int X;
    private int Y;

    // public Constructor
    public Point(int x, int y)
    {
        X = x; ///initialiazed based on new parameters passed 
        Y = y;
    }

    public int GetX()
    {
        return X;
    }

    public int GetY()
    {
        return Y;
    }
}

class TestPoint2Class
{
    static void Main()
    {//compiler starts here 
        Point pt = new Point(10, 20); //delaring and instantiating at the same time (create object)
        

        Console.WriteLine("{0},{1}", pt.GetX(), pt.GetY());
        Console.ReadLine();
    }
}