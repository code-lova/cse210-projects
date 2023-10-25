using System;
using System.Collections.Generic;


public class WritingAssignment : Assignment{

    private string _title = "";

    //Creating a consutructor 
    public WritingAssignment(string studentname, string topic, string title) : base(studentname, topic){

        _title = title;
    }

    public string GetWritingInformation(){

        string _studentname = StudentName; //using the getter we created in the  Assignmment class

        return $"{_title} By {_studentname}";
    }
}