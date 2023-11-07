using System;
using System.Collections.Generic;



public class Rectangle : Shape{

    private double _length = 0;
    private double _width = 0;


    public Rectangle(string color, double length, double width) : base(color){

        _length = length;
        _width = width;

    }

    public double Getlenght{
        get{ return _length; }
        set{ _length = value; }
    }

    public double GetWidth{
        get{ return _width; }
        set{ _width = value; }
    }


    public override double GetArea()
    {
        return Getlenght * GetWidth;
    }





}