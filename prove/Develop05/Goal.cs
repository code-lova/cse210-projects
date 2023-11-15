using System;
using System.Collections.Generic;
using System.Xml.Resolvers;

public abstract class Goal{

    private string _name = "";
    private string _points = "";
    private string _description = "";


    public Goal(string name, string description, string points){

        _name = name;
        _description = description;
        _points = points;
    }

    //Setters and getters
    public string GetName{
        get{ return _name; }
    }

    public string SetName{
        set{ _name = value; }
    }

    public string GetPoints{
        get{ return _points; }
    }

    // This setter enables the bonus in the checklist class 
    // to be decleared as a method to hold the points as a string
    public void SetPoints(string points){

        _points = points;
    }

    public string GetDescription{
        get{ return _description; }
    }


    //Methods or behaviours
    public abstract void RecordEvent();

    public abstract void SetComplete(bool value);

    public abstract bool IsComplete();

    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString(){

        string status  = "[ ]";
        if(IsComplete() == true){

            status = "[X]";
        }
        return $"{status} {GetName} ({GetDescription})";
    }





}