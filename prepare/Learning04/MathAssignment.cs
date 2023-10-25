using System;
using System.Collections.Generic;


public class MathAssignment : Assignment{

    private string _textbooksection = "";
    private string _problems = "";

    //createing constructors 
    public MathAssignment(string studentname, string topic, string textbooksection, string problems) : base(studentname, topic){
        _textbooksection = textbooksection;
        _problems = problems;
    }

    //Create a method 

    public string GetHomeworkList(){
        return $"Section {_textbooksection} Problems {_problems}";
    }

}