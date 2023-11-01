using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public class ReflectionActivity : MindfullnessActivity{

    private List<string> _prompt;
    private List<string> _questions;

    public ReflectionActivity(string name, string description) : base(name, description){

        _prompt = new List<string>{

            "--- Think of a time when you stood up for someone else. ---\n",
            "--- Think of a time when you did something really difficult. ---\n",
            "--- Think of a time when you helped someone in need. ---\n",
            "--- Think of a time when you did something truly selfless. ---\n",
        };

        _questions = new List<string>{

            "> Why was this experience meaningful to you?",
            "> Have you ever done anything like this before?",
            "> How did you get started?",
            "> How did you feel when it was complete?",
            "> What made this time different than other times when you were not as successful?",
            "> What is your favorite thing about this experience?",
            "> What could you learn from this experience that applies to other situations?",
            "> What did you learn about yourself through this experience?",
            "> How can you keep this experience in mind in the future?",
        };

    }


    
    public void StartReflection(){

        StartActivity();
        
        Console.WriteLine();

        Console.WriteLine("Consider the following prompt: \n");

        //string prompt = RandomPompt(_prompt);
        //Console.WriteLine(prompt);


        Shuffle(_prompt);

        for (int i = 0; i < 1; i++){

            Console.WriteLine($"{_prompt[i % _prompt.Count]}");
        }

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadKey();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to the experience");
        ShowCountdown("You may being in: ");

        Console.Clear();
        
        Shuffle(_questions);

       
        for (int i = 0; i < 2; i++){

            questionSpinners($"{_questions[i % _questions.Count]} ");

            Console.Write("");

        }


        /** THIS BLOCK OF CODE WILL DISPLAY ALL POSSIBLE 9 QUESTIONS WITHOUT DUBLICATIONS **/
        // Shuffle(_questions);

        //  for (int i = 0; i <= 9; i++){
                    
        //     questionSpinners($"{_questions[i % _questions.Count]} ");

        //     Console.Write("");
            
        // }

        
        Console.WriteLine("");
        EndActivity();
        Console.Clear();

    }







}