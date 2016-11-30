// File: Point5.cs
using System;

class Point
{
    private int x;
    private int y;

    public int X // X is the name of the propety
    {
        get
        {
            return x;
        }
        set
        {
            x = value;
        }
    }
    public int Y // Y is the name of the property
    {
        get
        {
            return y;
        }
        set
        {
            y = value;
        }
    }
}


class TestClass
{
    static void Main()
    {
        Point pt = new Point();

        pt.X = 5; //setting - change this
        pt.Y = 14;

        Console.WriteLine("pt is {0},{1}", pt.X, pt.Y);
        Console.ReadLine();
    }
}