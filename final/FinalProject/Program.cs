using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();
        Console.WriteLine("Welcome to SmartShop Shopping Cart Application!");
        Console.WriteLine("Where you can add products to your cart, get totoal amount and checkout");
        Console.WriteLine();

        ShoppingCartApp shoppingApp = new ShoppingCartApp();


        shoppingApp.StartApplication();








    }
}