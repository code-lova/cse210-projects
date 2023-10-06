using System;
using System.IO;
using System.Collections.Generic;

public class Journal{
    public List<Entry> journalList = new List<Entry>();


    public List<string> menuList = new List<string>();




    public void AddEntry(Entry myname){
       journalList.Add(myname);    

    }



    public void DisplayEntry(){

        foreach(Entry entry in journalList){
            
           entry.DisplayEntries(); //-> see function in Entry Class
           Console.WriteLine("");
            
        }
    }



    public void SaveEntryToFile(string fileName){

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Entry entry in journalList)

            outputFile.WriteLine($"Date:{entry._date}:Prompt:{entry._prompt}:MyResponse:{entry._entry}");
        }
    }



    
    public void LoadEntryFromFile(string fileName){

        /**Read file, line after line
            this will empty the console while we reload the files
        **/
        string[] lines = System.IO.File.ReadAllLines(fileName);

        //Iterating through the entries read from the file.
        foreach(string line in lines){

            // Console.WriteLine($"{splt[0]} {splt[1]} {splt[2]} {splt[3]} {splt[4]} {splt[5]}");      
            string[] splt = line.Split(":");
   
            /**Creating a new Entry varable "savingFile" to hold properties
                of our Entry class which then serves as varable to hold
                the entries read from the file.
            **/
            Entry savingFile = new Entry();     

            savingFile._date = splt[1];
            savingFile._prompt = splt[3];
            savingFile._entry = splt[5];
            
            /**Adding entries called from the fileName to the Entry List
                by calling the AddEntry method, that adds users entries to the list
            **/
            AddEntry(savingFile);
            
        }
    }



    public void DisplayMenu(){

        string choice1 = "1. Write";
        string choice2 = "2. Display";
        string choice3 = "3. Load";
        string choice4 = "4. Save";
        string choice5 = "5. Quit";

        menuList.Add(choice1);
        menuList.Add(choice2);
        menuList.Add(choice3);
        menuList.Add(choice4);
        menuList.Add(choice5);

        Console.WriteLine("Please select one of the following choices");

        //Iterating through the menu list to display to the user
        foreach(string details in menuList){
            Console.WriteLine(details);
        }
    }

    



   
}