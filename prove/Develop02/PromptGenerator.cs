using System;
using System.Net;
using System.Collections.Generic;

public class PromptGenertor{

    public List<string> randomQuestion = new List<string>();

    public string DisplayPrompt(){

        //Declearing varables to hold each prompt string.
        string randomPrompt1 = "What was the best part of my day?";
        string randomPrompt2 = "Who was the most interesting person I interacted with today?";
        string randomPrompt3 = "How did I see the hand of the Lord in my life today?";
        string randomPrompt4 = "If I had one thing I could do over today, what would it be?";
        string randomPrompt5 = "What was the strongest emotion I felt today?";

        //Adding each prompt string to a list "randomQuestion". to be picked randomly.
        randomQuestion.Add(randomPrompt1);
        randomQuestion.Add(randomPrompt2);
        randomQuestion.Add(randomPrompt3);
        randomQuestion.Add(randomPrompt4);
        randomQuestion.Add(randomPrompt5);

        /**selecting a string of prompt question from the list "randomQuestion" at random
            1. using a varable "getQuest" to hold and calling the Random method 
            2. Converting the selected string in the list to array of index - varable to hold integer
            3. Converting back to string 
        **/
        Random getQuest = new Random(); // -> 1
        int ans = getQuest.Next(randomQuestion.Count); // -> 2
        string randomString = randomQuestion[ans]; // -> 3
        
        //Display the random selected string of prompt to the user
        Console.WriteLine(randomString);

        return randomString;
        
    }

}