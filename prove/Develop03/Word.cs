using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


public class Word{

    private string _text;
    private bool _isHidden;

//Making Constructors 
    public Word(string text, bool isHidden = false){
        _text = text;
        _isHidden = isHidden;
    }

//GETTERS AND SETTERS

    public string Text{
        get {return _text;}
        set {_text = value; }
    }

    public bool IsHidden{
        get {return _isHidden;}
        set {_isHidden = value;}
    }

    //Methods 

    public void Hide(){
        _isHidden = true;
    }

    public void Show(){
        _isHidden = false;
    }

    public bool IsHiden(){
        return _isHidden;
    }

    public string GetRenderedText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }


}