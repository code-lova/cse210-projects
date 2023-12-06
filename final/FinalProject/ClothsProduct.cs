using System;
using System.Collections.Generic;
using System.IO;


public class ClothsProduct : Product
{

    private string _size = "";

    public ClothsProduct(string name, string price, string stockQuantity, string size): base(name, price, stockQuantity){

        _size = size;
    }

    public string GetSize{
        get{ return _size; }
    }

    public string SetSize{
        set{ _size = value; }
    }

    public override string Display()
    {
        return $"Cloth: {GetName} - Price: ${GetPrice} - Quantity: {GetStockQty} - Size: {GetSize}";
    }


    public override string DisplayProductString()
    {
        return $"Fashion:{GetName},{GetPrice},{GetStockQty},{GetSize}";
    }

}