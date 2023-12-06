using System;
using System.Collections.Generic;
using System.IO;

public class ElectronicProduct: Product{

    private string _brand = "";

    public ElectronicProduct(string name, string price, string stockQuantity, string brand): base(name, price, stockQuantity){

        _brand = brand;
    }

    //getters and setters
    public string GetBrand{
        get{ return _brand; }
    }

    public string SetBrand{
        set{ _brand = value; }
    }


    public override string Display()
    {
        return $"Electronic: {GetName} - Price: ${GetPrice} - Quantity: {GetStockQty} - Brand: {GetBrand}";

    }


    public override string DisplayProductString()
    {
        return $"Electronics:{GetName},{GetPrice},{GetStockQty},{GetBrand}";
        
    }



}