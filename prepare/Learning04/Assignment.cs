using System;
using System.Collections.Generic;

public class Assignment{

    private string _studentname = "";
    private string _topic = "";

    //Lets create a getter for studentname so we can use it
    //in our WritingAssignment class
    public string StudentName{
        get{ return _studentname; }
    }

    //Create constriuctor 
    public Assignment(string studentname, string topic){
        _studentname = studentname;
        _topic = topic;

    }

    //Create a method that returns the student and and topic 
    public string GetSummary(){
        return $"{_studentname} - {_topic}";
    }



}