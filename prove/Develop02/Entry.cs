using System;
using System.Collections.Generic;

public class Entry{
    
    public string _prompt;
    public string _entry;
    public string _date;


    public void DisplayEntries(){
        
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_entry}");
        
    }



}

   




