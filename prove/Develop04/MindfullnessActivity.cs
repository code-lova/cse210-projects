using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


public class MindfullnessActivity{

    private string _name = "";
    private string _description = "";
    private int _duration;
    private static readonly string[] spinnerFrames = { "|", "/", "-", "\\", "|", "/", "-", "\\" };
    private Random _random = new Random();



    //Making constructor
    public MindfullnessActivity(string name, string description){
        
        _name = name;
        _description = description;
    } 

    public void SetDuration(int duration){
        
        _duration = duration;
    }

    public int Duration{
        get{ return _duration; }
    }

    public void StartActivity(){
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session?: ");
        string ans = Console.ReadLine();
        int time = int.Parse(ans);
        SetDuration(time);
        Console.Clear();
        Console.WriteLine("Getting ready...");
        ShowSpinner();
    }

    public void EndActivity(){

        Console.WriteLine("Well done..!!");
        Thread.Sleep(250); // pause with an animation.
        ShowSpinner();
        Console.WriteLine("\r ");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner();
        
    }

    //Spinner for question in reflection activity.
    public List<string> QuestionSpinners(string message){

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
        DateTime endTime = startTime.AddSeconds(15); // how long the spinner should run

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



    public void ShowSpinner(){

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"\r{spinnerFrames[i % spinnerFrames.Length]}");
            Thread.Sleep(250); // Pause with a spinner animation
            Console.Write("\r "); // Overwrite the spinner with spaces
            Thread.Sleep(250); // Pause for a clean display
        }
        Console.WriteLine();
    }



    public void ShowCountdown(string message){

        Console.Write($"{message}");
        for (int i = 5; i > 0; i--){

            Console.Write(i);
            Thread.Sleep(1000); // Pause with a countdown timer
            Console.Write("\b \b"); // Erase each countdown number with a new countdown number
        }
        Console.WriteLine("");
    }




    //Pick Prompt at random for Listing activities.
    public string RandomPompt(List<string> list){

       int index = _random.Next(list.Count);
       string item = list[index];
       list.RemoveAt(index);
       return item;

    }



    //Shuffling the question for the Reflection activity.
    public void Shuffle(List<string> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = _random.Next(n + 1);
            string value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }



}