using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


public class BreathingActivity : MindfullnessActivity{


    public BreathingActivity(string name, string description) : base(name, description){

    }


    public void StartBreathing(){
        StartActivity();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration); // how long the actvity should run


        while(DateTime.Now < endTime){

            ShowCountdown("Breathe In...");
            ShowCountdown("Now Breathe Out...");
            Console.WriteLine("");
        }

        Console.WriteLine("");
        EndActivity();
        Console.Clear();

    }

}