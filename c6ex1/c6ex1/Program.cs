// File: VerySimple.cs
using System;

class VerySimple //useful tool or useful object
{
    int simpleValue; //field - declared

    public VerySimple()//constructor
    {
        simpleValue = 10;// initialize the field in the constructor 
    }

    //methods (functions)
    //properties
    //another class
    //enums
} //lines 1-16 is a toolbox

class TestVerySimpleClass 
{
    static void Main() //compiler starts at line 22
    {
        VerySimple ver; // notice that ver is null

        ver = new VerySimple();//instantiantion //key//give me an object of type me// creating a blueprint 
    }
}