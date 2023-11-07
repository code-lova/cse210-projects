using System;
using System.Collections.Generic;




public class Circle : Shape{

    private double _radius = 0;

    public Circle(string color, double radius) : base(color){

        _radius = radius;
    }

    public double GetRadius{
        get{ return _radius; }
        set{ _radius = value; }
    }


    public override double GetArea()
    {
        double pi = 3.14;

        return Math.Round(pi * GetRadius * GetRadius, 2);
    }



}