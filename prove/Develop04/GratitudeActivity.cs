using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;




public class GratitudeActivity : MindfullnessActivity{

    private List<string> _gratitude;

    public GratitudeActivity(string name, string description) : base(name, description){


        _gratitude = new List<string>{

            "Family & Friends",
            "Good Health",
            "Work & Opportunities",
            "The Great Atonement of Jesus Christ",
            "The Church and the Restored Gospel",

        }; 
    }


    public void StartGratitude(){

        StartActivity();
        
        Console.WriteLine();

        Console.WriteLine("Reflect on the following things you are grateful for:\n");

        ShowCountdown("You may being in: ");

        Console.Clear();

        foreach (string item in _gratitude)
        {
            QuestionSpinners($"{item} ");
        }

        Console.WriteLine();

        Console.WriteLine("When you are done reflecting, press enter to continue..");
        Console.ReadLine();

        Console.Clear();

        QuestionSpinners("Now take a moment to appreciate these blessings in your life. ");

        Console.WriteLine();
        EndActivity();
        Console.Clear();

    }



}