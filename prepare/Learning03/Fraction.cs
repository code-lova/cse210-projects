using System;
using System.IO.Pipes;

public class Fraction{

    private int _top;
    private int _bottom;

    //CREATING CONSTRUCTORS
    public Fraction(){
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top){

        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }

    //DECLEARING GETTERS AND SETTERS 
    public int GetTop(){
        return _top;
    }

    public void SetTop(int top){
        _top = top;
    }

    public int GetBottom(){
        return _bottom;
    }

    public void SetBottom(int bottom){
        if (bottom != 0){
            _bottom = bottom;
        }else{
            throw new ArgumentException("Dinominator cannot be 0");
        }
    }

    //Create methods to return the representations

    public string GetFractionString(){
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue(){
        return (double) _top / _bottom;
    }




}