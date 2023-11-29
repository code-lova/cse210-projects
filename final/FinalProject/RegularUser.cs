using System;
using System.Collections.Generic;
using System.IO;

public class RegularUser: User{

    private string _regularUserName = "";

    public RegularUser(string username, string regularUserName): base(username){

        _regularUserName = regularUserName;        
    }

    //getters and setters
    public string GetRegularName{

        get{ return _regularUserName; }
    }

    public string SetRegularName{

        set{ _regularUserName = value; }
    }



}