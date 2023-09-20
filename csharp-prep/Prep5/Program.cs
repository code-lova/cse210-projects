using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();

        string userName = PromptUserName();
        int favNumber = PromptUserNumber();

        int sqrInput = SquareNumber(favNumber);

        DisplayResult(userName, sqrInput);


    }

    //function todisplay a message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favourite number: ");
        string userString = Console.ReadLine();
        int number;
        number = int.Parse(userString);
        return number;

    }

    static int SquareNumber(int number)
    {
        int sqrUserNumber = number * number;
        return sqrUserNumber;
    }

    static void DisplayResult(string name, int sqrUserNumber)
    {
        Console.WriteLine($"{name} the square of your number is {sqrUserNumber}");
    }



}