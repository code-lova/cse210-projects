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

            LoadProduct();
        }
    
        

    }



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
        DateTime endTime = startTime.AddSeconds(6); // how long the spinner should run

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
            Console.WriteLine("3. Edit Product");
            Console.WriteLine("4. Save Product");
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

                }

            }else if(choice == 2){

                Console.Clear();
                ViewProduct();
                Console.WriteLine();

            }else if(choice == 3){

                
            }else if(choice == 4){

                
            }else if(choice == 5){

                
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


    public void EditProduct(){


    }


    public void DeleteProduct(){


    }

    public void SaveProductToFile(){



    }

    //behaviours for regular user

    public void LoadProduct(){

        //Implement load product from saved file first before showing this menu to user
        //User dont have any authentication method

        Console.WriteLine("Welcome Guest User");
        Console.WriteLine("1. Shop For Products");
        Console.WriteLine("2. View Cart");
        Console.WriteLine("3. Check out");
        Console.WriteLine("4. Logout");

        Console.Write("What do you want to do today? ");

    }


    public void AddToCart(){


    }


    public void DisplayCart(){



    }


    public void CheckOut(){


        
    }




}