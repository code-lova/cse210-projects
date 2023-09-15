using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");
        Console.Write("Please enter your score to determine your grade: ");
        //1. Read the user input and hold it in a varable named 'userInput' from terminal
        string userInput = Console.ReadLine();
        //2. assign a new varable with a data type of integer
        int score;
        // 3. Converting the user input as string to an integer
        // Use the new varable assigned above "score" to hold the userInput
        // Converting to interger
        score = int.Parse(userInput);
        // 4. Getting the reminder when the userInput is divided by 10
        int remainingNumber = score % 10;
        // 5. Assiging new varables "scoreSign" and "letter" to empty string.
        string scoreSign = "";
        string letter = "";

        // 6. using if statement to determine the grade
        if(score >= 90){
            letter = "A";
        }else if(score >= 80){
            letter = "B";
        }else if(score >= 70){
            letter = "C";
        }else if(score >= 60){
            letter = "D";
        }else{
            letter = "F";
        }

        //determing the sign to attach to the grade
        if(remainingNumber >= 7){
            scoreSign = "+";
        }else if(remainingNumber < 3){
            scoreSign = "-";
        }else{
            scoreSign = "";
        }

        //If score is greater or equal to 90
        //Dont add a scoreSign
        if(score >= 95){
            scoreSign = "";
        }else if(score < 95){
            scoreSign = "-";
        }

        //If letter is F 
        //Dont add a scoreSign
        if(letter == "F"){
            scoreSign = "";
        }

        //Print out a message depending on the user Grade.
        if(letter == "A" || letter == "B" || letter == "C" || letter == "D"){
            Console.Write($"Congratulations.!! You Passed with grade: {letter}{scoreSign}.");
        }else{
            Console.WriteLine($"SORRY..!! you did poorly, you got an: {letter}{scoreSign}.\nBetter luck next time!.");
        }

    }
}