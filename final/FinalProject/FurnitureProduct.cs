using System;
using System.Collections.Generic;
using System.IO;

public class FurnitureProduct: Product{

    private string _type = "";

    public FurnitureProduct(string name, string price, string stockQuantity, string type): base(name, price, stockQuantity){

        _type = type;

    }

    //getters and setters

    public string GetFurnitureType{
        get{ return _type; }
    }

    public string SetFurnitureType{
        set{_type = value; }
    }

    public override string Display(){

        return $"Furniture: {GetName} - Price: ${GetPrice} - Quantity: {GetStockQty} - Type: {GetFurnitureType}";
    }


    public override string DisplayProductString()
    {
        return $"Furniture:{GetName},{GetPrice},{GetStockQty},{GetFurnitureType}";

    }


}