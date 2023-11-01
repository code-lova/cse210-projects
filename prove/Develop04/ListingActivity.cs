using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


public class ListingActivity : MindfullnessActivity{

    private List<string> _listPrompt;

    private List<string> _response;


    public ListingActivity(string name, string description) : base(name, description){

        _listPrompt = new List<string>{

            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };

        _response = new List<string>();


    }




    public void StartListing(){

        StartActivity();

        string prompting = RandomPompt(_listPrompt);

        Console.WriteLine("List as many response as you can to the follwoing prompt\n");
        
        Console.WriteLine($"--- {prompting} ---");

        ShowCountdown("You may being in:  ");
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration); // how long the activity should run


        while(DateTime.Now < endTime){

            Console.Write("> ");
            string response = Console.ReadLine();
            _response.Add(response);

        }
         
       
        Console.WriteLine($"you have listed {_response.Count} items");
        
        Console.WriteLine("");
        EndActivity();
        Console.Clear();

    }




}