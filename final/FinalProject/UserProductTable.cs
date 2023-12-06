using System;
using System.Collections.Generic;
using System.IO;


public class UserProductTable : Product{


    private string _category = "";
    private string _stb = "";
   
    public UserProductTable(string category, string name, string price, string stockQuantity, string stb): base(name, price, stockQuantity){

        _category = category;
        _stb = stb;
    }

    //getters and setters 

    public string GetCat{

        get{ return _category; }
    }

    public string Setcat{

        set{_category = value; }
    }

    public string GetStb{
        get{ return _stb; }
    }

    public string SetStb{

        set{ _stb = value; }
    }



    public override string DisplayProductString()
    {
        return $"{GetCat}:{GetName},{GetPrice},{GetStockQty},{GetStb}";
    }

   
}