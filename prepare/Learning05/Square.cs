using System;
using System.Collections.Generic;


public class Square : Shape{

    private double _sides = 0;

      /** 
        MAKING A CONSTRUCTOR
    **/
    public Square(string color, double sides) : base(color){
        _sides = sides;
    }

    public double GetSide{
        
        get{ return _sides; }
        set{ _sides = value; }
    }


    public override double GetArea()
    {
        return GetSide * GetSide;
    }

}