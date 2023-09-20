using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished");


        int userInput = 1;
        Boolean addNumbers = false;
        List<int> numbers = new List<int>();


        while(addNumbers == false && userInput != 0){
            Console.Write("Enter a number: ");

            string stringInput = Console.ReadLine();

            userInput = int.Parse(stringInput);

            if(userInput != 0){

                numbers.Add(userInput);

            }

            if(userInput == 0){
                addNumbers = true;
            }else{
                addNumbers = false;
            }
        }

        if (true){
            int total = numbers.AsQueryable().Sum();
            double average = numbers.AsQueryable().Average();
            long maxNumber = numbers.AsQueryable().Max();

            //To get the smallest positive number.
            int minPositve = numbers.Min();
            foreach(int number in numbers){
                if (number > 0){
                    minPositve = number;
                }
            }

            Console.WriteLine($"Sum: {total}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"largest Number is: {maxNumber}");
            Console.WriteLine($"Min positive number is: {minPositve}");
            
            numbers.Sort();
            foreach (int number in numbers){
                Console.WriteLine(number);
            }


        }





    }
}