using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        string bibleText = "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways acknowledge him, and he will make your paths straight.";

        Reference reference = new Reference("Proverbs", "3", "5", "6");

        Scripture scripture = new Scripture(reference, bibleText);

        string user = "";
        while (user != "quit"){
                        
            Console.Clear();

            scripture.GetRenderedtext();

            Console.WriteLine("\n\nPress enter to continue or type quit to exit");
            Console.WriteLine();


            if (scripture.IsCompletelyHidden()){
                break;
            }
            user = Console.ReadLine();


            if (user == "quit")
                break;

            scripture.HideWords(2);
        }

    }
}