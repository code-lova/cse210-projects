using System;
using System.Collections.Generic;
using System.IO;
using System.Data.SqlTypes;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading;


public class ShoppingCartApp{

    private List<Product> _itemList = new List<Product>();

    private List<User> _usersList = new List<User>();

    private List<UserProductTable> _productTable = new List<UserProductTable>();

    private List<UserProductTable> _cart = new List<UserProductTable>();

   

    //getters and setters
    public List<Product> GetItemList{

        get{ return _itemList; }
    }

    public List<User> GetUserList{

        get{ return _usersList; }
    }



    public void SetItemList(Product itemList){

        _itemList.Add(itemList);
    }


    public void SetUserList(User usersList){

        _usersList.Add(usersList);
    }


    

    public void StartApplication(){
        

        Console.WriteLine("Login as: ");

        Admin admin = new Admin("Admin", "123456");
        SetUserList(admin);

        RegularUser regularUser = new RegularUser("Regular User", "");
        SetUserList(regularUser);

        foreach(User user in _usersList){

            Console.WriteLine($"{_usersList.IndexOf(user) + 1}. {user.ShowUsers()} ");

        }

        Console.Write("Enter 1 to login as Admin or 2 as Regular User, Respectively: ");
        string input = Console.ReadLine();
        int choice = int.Parse(input);

        //Autheticate according to users role
        if(choice == 1){

            Console.Clear();
            Console.Write("Enter UserName: ");
            string username = Console.ReadLine();

            Console.Write("Enter Pasword: ");
            string password = Console.ReadLine();

            //Authenticate Admin
            //Implement password authrntication and spinners here before showing CreateProduct behaviour
            if(username == "Admin" && password == "123456"){
                Console.Clear();
                ShowSpinner("Authenticating... ");
                Thread.Sleep(250);
                Console.WriteLine("Login successful!");
                CreateProduct();
            }else{
                Console.Clear();
                ShowSpinner("Authenticating... ");
                Console.Clear();
                Console.WriteLine("Incorrect Credentials...Try Again!\n");
            
            }
        }
        else if(choice == 2){
            
            Console.Clear();

            //User dont have any authentication method
            Boolean start  = true;

            while( start == true){

                
                Console.WriteLine("Welcome Guest User");
                Console.WriteLine("1. Add Item Cart");
                Console.WriteLine("2. View Cart");
                Console.WriteLine("3. Check out");
                Console.WriteLine("4. Logout");

                Console.Write("What are you doing today: ");

                //Implement view product from saved file first before showing this menu to user

                string getInput = Console.ReadLine();
                int selection;

                if(int.TryParse(getInput, out selection))
                {

                    switch (selection)
                    {

                        case 1:
                            Console.Clear();
                            ShowSpinner("Loading available products... ");
                            Console.Clear();
                            DisplayProduct();
                            Console.WriteLine();

                            Console.Write("Enter the index of the item you want to add to the cart: ");
                            if(int.TryParse(Console.ReadLine(), out int userChoice) && userChoice > 0 && userChoice <= _productTable.Count){

                               
                                Console.Write("Enter the quantity: ");
                                if (int.TryParse(Console.ReadLine(), out int quantity) && quantity > 0){

                                    //Remove 1 from the index in the cart list
                                    int pIndex = userChoice - 1;
                                
                                    AddToCart(pIndex, quantity);

                                }else{

                                    Console.WriteLine("Invalid quantity. Please enter a valid positive integer.\n");

                                }
                               
                                    
                            }else{

                                Console.WriteLine("Invalid index. Please enter a valid index number.");
                                Console.WriteLine();

                            }

                            break;

                        case 2:

                            ShowCart();
                            break;

                        case 3:

                            CheckOut();
                            break;

                        case 4:

                            start = false;
                            //Exiting the loop after checkout

                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Invalid selection. Please enter a valid option.");
                            Console.WriteLine();
                            break;

                    }
                   

                }else{

                    Console.WriteLine("Invalid input. Press Enter to try again");
                    Console.ReadLine(); // Wait for user input before clearing the console
                }

            }

        
        }else if(choice > _usersList.Count){

            Console.WriteLine("Invalid User Input.. Try again.\n");
        }
    
    }





    //Behaviours for Administartor

     public List<string> ShowSpinner(string message){

        List<string> theSpinner = new List<string>();
        theSpinner.Add("|");
        theSpinner.Add("/");
        theSpinner.Add("-");
        theSpinner.Add("\\");
        theSpinner.Add("|");
        theSpinner.Add("/");
        theSpinner.Add("-");
        theSpinner.Add("\\");

        Console.Write($"{message} ");
        
        int i = 0;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5); // how long the spinner should run

        while(DateTime.Now < endTime){
            string s = theSpinner[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            //if i is greter than or equal the number of list
            //start the spinner from the beginning
            if(i >= theSpinner.Count){

                i = 0;
            }
                
        }
        Console.WriteLine("");
        
        return theSpinner;
    }




    public void CreateProduct(){
        Console.Clear();

        Boolean start  = true;
        while( start == true){

        
            Console.WriteLine("Welcome Admin");
            Console.WriteLine("1. Create Products");
            Console.WriteLine("2. View Products");
            Console.WriteLine("3. Save Product");
            Console.WriteLine("4. Load Product");
            Console.WriteLine("5. Delete Product");
            Console.WriteLine("6. Logout");

            Console.Write("What do you want to do today? ");


            string input = Console.ReadLine();

            int choice = int.Parse(input);



            if(choice == 1){

                //Implement what type of product the admin is adding
                /**
                    Either an Electronic product
                    Clothing product
                    or Furniture product

                    Then change product class to an abstract class.
                **/
                Console.Clear();
                Console.WriteLine("Product Categories ?");
                Console.WriteLine("1. Fashion Product");
                Console.WriteLine("2. Electronic Product");
                Console.WriteLine("3. Furniture Product");
                Console.Write("what catrgory of product are you adding today? ");

                string selection = Console.ReadLine();
                int category = int.Parse(selection);


                if (category == 1){

                    Console.Clear();
                    Console.Write("What is the Name of the Cloth: ");
                    string name = Console.ReadLine();
                    Console.Write("What is the Cloth Price: ");
                    string price = Console.ReadLine();
                    Console.Write("What is the Stock Quantity of the Cloth: ");
                    string stockQuantity = Console.ReadLine();
                    Console.Write("What is the Size of the Cloth: ");
                    string size = Console.ReadLine();

                    ClothsProduct cloth = new ClothsProduct(name, price, stockQuantity, size);
                    SetItemList(cloth);
                    Console.Clear();

                }else if(category == 2){

                    Console.Clear();
                    Console.Write("What is the Name of the Electronic: ");
                    string name = Console.ReadLine();
                    Console.Write("What is the Price of the Electronic: ");
                    string price = Console.ReadLine();
                    Console.Write("What is the Stock Quantity of the Electronic: ");
                    string stockQuantity = Console.ReadLine();
                    Console.Write("What is the brand of the Electronic: ");
                    string brand = Console.ReadLine();

                    ElectronicProduct electronic = new ElectronicProduct(name, price, stockQuantity, brand);
                    SetItemList(electronic);
                    Console.Clear();

                }else if(category == 3){

                    Console.Clear();
                    Console.Write("What is the Name of the Furniture: ");
                    string name = Console.ReadLine();
                    Console.Write("What is the Price of the Furniture: ");
                    string price = Console.ReadLine();
                    Console.Write("What is the Stock Quantity of the Furniture: ");
                    string stockQuantity = Console.ReadLine();
                    Console.Write("What is the brand of the Furniture: ");
                    string type = Console.ReadLine();

                    FurnitureProduct furniture = new FurnitureProduct(name, price, stockQuantity, type);
                    SetItemList(furniture);
                    Console.Clear();

                }else if(category > 3){

                    Console.WriteLine($"Invalid Index Number {category}\n");
                }

            }else if(choice == 2){

                Console.Clear();
                ViewProduct();
                Console.WriteLine();

            }else if(choice == 3){

                 if(_itemList.Count > 0){

                    Console.Clear();
                    ShowSpinner("Saving please wait... ");
                    Console.Clear();
                    Console.WriteLine("saved successfully!");
                    SaveProductToFile();

                }else{

                    Console.Clear();
                    Console.WriteLine("The product list is Empty..!!!\n");

                }

            }else if(choice == 4){

                Console.Clear();
                ShowSpinner("Loading please wait... ");
                Console.Clear();
                Console.WriteLine("Product loaded successfully!");
                LoadProduct();
               
                
            }else if(choice == 5){

                Console.Clear();
                DeleteProduct();
                
            }else if(choice == 6){

                start = false;
            }
        }       

    }



    public void ViewProduct(){

        if(_itemList.Count >= 1){

            Console.WriteLine("List of products are:  ");
            foreach(Product item in _itemList){

                Console.WriteLine($"{_itemList.IndexOf(item) + 1}. {item.Display()} ");
            }

        }else{

            Console.WriteLine("Your Product Entry List is empty for now");

        }
        

    }


    public void LoadProduct(){

        if(File.Exists("products.txt")){

            _itemList.Clear();

             string[] lines = File.ReadAllLines("products.txt");

            if(lines.Length > 0){

                //load products
                foreach(string line in lines){

                    string[] part = line.Split(":");
                    string category = part[0];
                    string product = part[1];

                    if(category == "Fashion"){

                        string[] productPart = product.Split(",");
                        string productName = productPart[0];
                        string productPrice = productPart[1];
                        string productStkQty = productPart[2];
                        string productSize = productPart[3];

                        ClothsProduct cloths = new ClothsProduct(productName, productPrice, productStkQty, productSize);
                        _itemList.Add(cloths);


                    }else if(category == "Electronics"){

                        string[] productPart = product.Split(",");
                        string productName = productPart[0];
                        string productPrice = productPart[1];
                        string productStkQty = productPart[2];
                        string productBrand = productPart[3];

                        ElectronicProduct electronics = new ElectronicProduct(productName, productPrice, productStkQty, productBrand);
                        _itemList.Add(electronics);


                    }else if(category == "Furniture"){

                        string[] productPart = product.Split(",");
                        string productName = productPart[0];
                        string productPrice = productPart[1];
                        string productStkQty = productPart[2];
                        string productType = productPart[3];

                        FurnitureProduct furniture = new FurnitureProduct(productName, productPrice, productStkQty, productType);
                        _itemList.Add(furniture);
                    }

                }

            }else{

                Console.WriteLine("The file products.txt doesn't have any information!");

            }

        }else{

            Console.WriteLine($"No available products in products.txt..!!");
        }

    }




    public void DeleteProduct(){

        ViewProduct();
        Console.WriteLine();
        Console.Write("Specify product to delete with index number: ");
        string select = Console.ReadLine();
        int productIndex = int.Parse(select);

        if(productIndex > 0 && productIndex <= _itemList.Count){


            //Remove the product at specified index

            int numberToDelete = productIndex - 1;

            _itemList.RemoveAt(numberToDelete);
            ShowSpinner("Deleting please wait... ");
            Console.Clear();
            Console.WriteLine("Product Deleted successfully!\n");



        }else{

            Console.WriteLine($"Invalid product index {productIndex}");
        }

    }



    public void SaveProductToFile(){

       
        using(StreamWriter newFile = new StreamWriter("products.txt")){

            foreach(Product item in _itemList){

                newFile.WriteLine($"{item.DisplayProductString()}");
            }
        }
    }







    //Behaviours for regular user

    public void LoadProductInTable(){

         if(File.Exists("products.txt")){
            _productTable.Clear();

            string[] lines = File.ReadAllLines("products.txt");

            if(lines.Length > 0){

                foreach (string item in lines){

                    string[] part = item.Split(":");
                    string categories = part[0];
                    string productList = part[1];

                    string[] tablePart = productList.Split(",");
                    string name = tablePart[0];
                    string price = tablePart[1];
                    string qty = tablePart[2];
                    string stb = tablePart[3];

                    UserProductTable table = new UserProductTable(categories, name, price, qty, stb);
                    _productTable.Add(table);
                   
                }


            }else{

                Console.WriteLine("There are no available producs in the product table");

            }

        }else{

            Console.WriteLine($"No available products for now...!!");


        }


    }




    public void DisplayProduct(){

        LoadProductInTable();
        if(_productTable.Count > 0){
            
            Console.WriteLine("List of available producs: ");
            foreach(UserProductTable item in _productTable){

                Console.WriteLine($"{_productTable.IndexOf(item) + 1}. {item.DisplayProductString()}");
            }

        }else{

            Console.WriteLine("No available product in the Product table for now\n");

        }
       

    }




    public void AddToCart(int index, int quantity){

        Console.Clear();
        ShowSpinner("Adding item to cart.... ");
        Console.Clear();
        UserProductTable selectedProduct = _productTable[index];

        //Convert the qunatity to string first before adding to cart
        string makeQty = quantity.ToString();
        selectedProduct.SetStockQty = makeQty;

        _cart.Add(selectedProduct);

        Console.WriteLine($"{selectedProduct.GetStockQty}, {selectedProduct.GetStb} - {selectedProduct.GetName} - ${selectedProduct.GetPrice} added to the cart");
        Console.WriteLine();
        
    }




    public void ShowCart(){

        Console.Clear();
        ShowSpinner("Getting Cart Contents... ");
        Console.Clear();
        if (_cart.Count > 0){

            Console.WriteLine("Cart Contents:");

            for (int i = 0; i< _cart.Count; i++){

                Console.WriteLine($"{i + 1}. {_cart[i].GetName}, Price: ${_cart[i].GetPrice:C}, {_cart[i].GetStb}, Quantity: {_cart[i].GetStockQty}.");

            }

            Console.WriteLine();
            Console.WriteLine($"Total Amount: {CalculateTotalAmount():C}");
            Console.WriteLine();


        }else{

            Console.WriteLine("Your Cart is Empty\n");
            Console.WriteLine($"Total Amount: {CalculateTotalAmount():C}");
            Console.WriteLine();
        }
       
    }



     public  decimal CalculateTotalAmount(){

        decimal totalAmount = 0;

        foreach (var item in _cart)
        {
            //Converting price from string to int
            string numberStr = item.GetPrice;
            int price = int.Parse(numberStr);

            //Converting quantity from string to int
            string qtyStr = item.GetStockQty;
            int quantity = int.Parse(qtyStr);

            totalAmount += price * quantity;
        }

        return totalAmount;
    }




    public void CheckOut(){

        if(_cart.Count < 0){

            Console.WriteLine("Your Cart is Empty ");
        }else{

            Console.Clear();
            ShowSpinner("Loading Checkout... ");
            Console.Clear();
            ShowCart();
            Console.WriteLine("Thank you for shopping with us! Your order has been placed.");
            Console.WriteLine();
        }

        
        
    }




}