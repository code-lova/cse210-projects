using System;
using System.Collections.Generic;
using System.IO;

public abstract class User{

    private string _username = "";

    public User(string username){

        _username = username;
    }


    //Getters and setters

    public string GetUserName{

        get{ return _username; }
    }

    public string SetUserName{

        set{_username = value; }
    }


    public string ShowUsers(){

        return $"{GetUserName}";
    }

  


}