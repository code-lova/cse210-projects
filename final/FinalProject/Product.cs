using System;
using System.Collections.Generic;
using System.IO;

public abstract class Product{

    private string _name = "";
    private string _price;
    private string _stockQuantity = "";


    //declearing constructors 
    public Product(string name, string price, string stockQuantity){

        _name = name;
        _price = price;
        _stockQuantity = stockQuantity;
    }

    //getters and setters 

    public string GetName{
        get{ return _name; }
    }

    public string SetName{
        set{_name = value; }
    }

    public string GetPrice{
        get{ return _price; }
    }

    public string SetPrice{
        set{ _price = value; }
    }

    public string GetStockQty{
        get{ return _stockQuantity; }
    }

    public string SetStockQty{
        set{ _stockQuantity = value; }
    }

    public abstract string DisplayProductString();

    public virtual string Display(){

        return $"Name: {GetName} - Price: ${GetPrice} - Quantity: {GetStockQty} ";
    }


}
