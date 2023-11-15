using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!, welcome to Polymorpism ");

        GoalManager goalManager = new GoalManager();

        Boolean start  = true;
        int option;

        while(start == true){

            Console.WriteLine();

            goalManager.DisplayScore();
            
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            option = int.Parse(choice);

            if (option == 1){

                //Create New Goal
                Console.Clear();
                goalManager.CreateGoal();

            }else if(option == 2){

                //List the Goals
                Console.Clear();
                goalManager.ListGoalDetails();

            }else if(option == 3){

                //Save the Goals
                Console.Clear();
                Console.Write("What is the filename for goal file? ");
                string fileName = Console.ReadLine();
                goalManager.SaveGoal(fileName);

            }else if(option == 4){

                //Load Goals
                Console.Clear();
                Console.Write("What is the name of the file you are loading? ");
                string fileName = Console.ReadLine();
                goalManager.LoadGoals(fileName);

            }else if(option == 5){

                //Record Event
                Console.Clear();
                goalManager.RecordEvent();

            }else if(option == 6){

                start = false;

            }









        }

    }
}