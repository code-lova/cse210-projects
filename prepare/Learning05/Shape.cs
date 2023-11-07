using System;
using System.Collections.Generic;


public abstract class Shape{

    private string _color = "";


    /** 
        MAKING A CONSTRUCTOR
    **/
    public Shape(string color){

        _color = color;
    }

    /** 
        CREATE A GETTER AND SETTER
    **/

    public string Color{
        get{ return _color; }
        set{ _color = value; }
    }


    // we will make this method an abstract so we
    // so therefor we make the whoe class an abstract class
    public abstract double GetArea();



    public string GetColor(){

        return Color;
    }






}