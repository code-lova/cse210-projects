using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!\n");


        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        string assignentDetails1 = assignment.GetSummary();
        Console.WriteLine($"{assignentDetails1}\n");

        

        MathAssignment mathassignment = new MathAssignment("Roberto Rodriguez","Fractions", "7.3", "8-19");
        string assignentDetails2 = mathassignment.GetSummary();
        string mathtProblem = mathassignment.GetHomeworkList();

        Console.WriteLine(assignentDetails2);
        Console.WriteLine($"{mathtProblem}\n");

        

        WritingAssignment writingassign = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II" );
        string assignentDetails3 = writingassign.GetSummary();
        string writing = writingassign.GetWritingInformation();

        Console.WriteLine(assignentDetails3);
        Console.WriteLine($"{writing}\n");



    }
}