using System;
using System.Net;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        /**creating new instances of the objects and declearing it
        as global varables**/
        PromptGenertor p = new PromptGenertor(); //->see PrompGenerator function
       
        Journal lis = new Journal();
        

        //declearing varables for the program
        string userInput;
        Boolean stopJournal  = false;

        //Using a while loop for the program
        while(stopJournal == false){

            /**creating a new instance of the Journal class
                to call the Display menu 
            **/
            Journal newMenu = new Journal();
            newMenu.DisplayMenu();

            //Asking the user a question
            Console.Write("What would you like to do ? ");
            userInput = Console.ReadLine();
            int convetInput;
            convetInput = int.Parse(userInput);

            //declearing date and prompt as string
            string date;
            string prompt;

            if(convetInput == 1){

                /**calling the PromptgGenerator class to display a random
                    prompt to the user.
                **/
                prompt = p.DisplayPrompt();

                //collecting user Entry to the prompt question
                Console.Write("> ");
                string entry = Console.ReadLine();
                
                //date varable to hold the inbuilt C# DateTime method 
                date = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");

                /**Declearing a new instance of Entry class with a varable "entryArray",
                    to hold properties from the Entry class
                **/
                Entry entryArray = new Entry();

                entryArray._entry = entry;
                entryArray._date = date;
                entryArray._prompt = prompt;

                //Adding the property values to a list "Enrty" called in the Journal class
                lis.AddEntry(entryArray);

                //Displaying the new entry from te Entry List.
                Console.WriteLine($"Date: {entryArray._date} - Prompt: {entryArray._prompt}\n{entryArray._entry}");

            }else if(convetInput == 2){

                //Display list of all entries in the journal.
                lis.DisplayEntry();
                
            }else if(convetInput == 3){

                Console.WriteLine("What is the file name");
                string fileName = Console.ReadLine();

                Console.WriteLine("Loading content from file....");
                Console.WriteLine("");

                //Load the journal entries from the given filename -> see function in Journal Class
                lis.LoadEntryFromFile(fileName);

                //Display all the loaded entries from the filename -> see function in Journal Class
                lis.DisplayEntry();


            }else if (convetInput == 4){
               
                Console.WriteLine("What is the file name");
                string fileName = Console.ReadLine();

                Console.WriteLine("Saving to file....");

                //Save the journal entries to the given filename -> see function in Journal Class
                lis.SaveEntryToFile(fileName);

            }else if(convetInput == 5){

                stopJournal = true;
            }
            
        }
       
        
        
    }
}