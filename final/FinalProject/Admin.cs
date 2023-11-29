using System;
using System.Collections.Generic;
using System.IO;


public class Admin: User{


    private string _password = "";

    public Admin(string username, string password): base(username){

        _password = password;
    }

    public string GetPassword{
        get{return _password; }
    }

    public string SetPassword{
        set{_password = value; }
    }

    public virtual void Password()
    {
        _password = GetPassword;
    }

}