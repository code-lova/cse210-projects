using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        //Lets initialize varables here to use a loop in the program
        Boolean guessCorrectly = false;
        int numberOfGuess = 0;
        string response = "yes";

        Random randonGenerator = new Random();
        int answer = randonGenerator.Next(1, 100);
        
        Console.WriteLine(answer);
      
        //using a while loop to iterate the user guess
        //Until they get the right answer
        while(response == "yes" || guessCorrectly == false){
            Console.Write("What is your guess? ");
            string takeInput = Console.ReadLine();
            int cvtInput;
            cvtInput = int.Parse(takeInput);

            if(cvtInput < answer){
                Console.WriteLine("Higher");
            }else if(cvtInput > answer){
                Console.WriteLine("Lower");
            }else if(cvtInput == answer){
                Console.WriteLine("You guessed it..!!");
                Console.WriteLine($"It took you {numberOfGuess} guesses");
            }

            if (cvtInput == answer){
                guessCorrectly = true;
            }else{
                guessCorrectly = false;
                numberOfGuess += 1;
            }

            if (guessCorrectly == true){
                Console.Write("Do you want to play again? yes/no: ");
                response = Console.ReadLine();
            }
        }

    
    }
}