using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


public class Reference{

    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;

    public Reference(string book, string chapter, string verse){
        _book = book;
        _chapter  = chapter;
        _verse = verse;
        _endVerse = null;
    }

    public Reference(string book, string chapter, string startVerse, string endVerse){
        _book = book;
        _chapter  = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    //Getters and setters

    public string Book{
        get {return _book;}
        set {_book = value;}
    }

    public string Chapter{
        get { return _chapter;}
        set { _chapter = value; }
    }

    public string Verse{
        get {return _verse;}
        set {_verse = value;}
    }

    public string EndVerse{
        get { return _endVerse;}
        set {_endVerse = value;}
    }

     public string GetDisplayText(){
        if(_endVerse == null)
            return $"{_book} {_chapter}:{_verse} ";
        else
            return $"{_book} {_chapter}:{_verse}-{_endVerse} ";
    }





}