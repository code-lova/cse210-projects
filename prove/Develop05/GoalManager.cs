using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.IO;

public class GoalManager{

    private int _score = 0;

    List<Goal> _goalList = new List<Goal>();


    //getters and setters
    public int GetScore{

        get{ return _score; }

    }

    public void SetScore(int score){

        _score += score;

    }

    public List<Goal> GetList{

        get{ return _goalList; }

    }


    public void SetList(Goal goalList){

         _goalList.Add(goalList);
    }



    public void CreateGoal(){

        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. CheckList Goal");
        Console.Write("Which type of goal would you like to create? ");

        string choice = Console.ReadLine();

        int goalChoice = int.Parse(choice);

        if (goalChoice == 1){

            Console.Write("What is the name of your goal: ");
            string name = Console.ReadLine();
            Console.Write("What is the short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            SimpleGoal sg = new SimpleGoal(name, description, points);
            SetList(sg);

        }else if(goalChoice == 2){

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is the short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            EternalGoal eg = new EternalGoal(name, description, points);
            SetList(eg);

        }else if(goalChoice == 3){

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is the short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
           
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            CheckListGoal clg = new CheckListGoal(name, description, points, bonus, target);
            SetList(clg);


        }


    }


    //Listing the number of goals that the user have created.
    public void ListGoalDetails(){

        Console.WriteLine("The goals are: ");
        foreach(Goal goal in _goalList){

            Console.WriteLine($"{_goalList.IndexOf(goal) + 1}. {goal.GetDetailsString()} ");
        }
    }


    public void SaveGoal(string file){

        //Console.Write("What is the filename for goal file? ");

        if (_goalList.Count > 0){

            string fileName = file;

            using(StreamWriter newFile = new StreamWriter(fileName)){

                newFile.WriteLine(GetScore);
                foreach(Goal goal in _goalList){

                    newFile.WriteLine($"{goal.GetStringRepresentation()}");
                }
            }

        }else{

            Console.WriteLine("There are no available goals to save at this time.");
        }

    }


    public void LoadGoals(string file){

        //Check if the file exists
        if(File.Exists(file)){

            _goalList.Clear();

            string fileName = file;

            string[] lines = File.ReadAllLines(fileName);

            if (lines.Length > 0){

                //load score
                _score = int.Parse(lines[0]);

                //Load goals
                foreach(string line in lines.Skip(1)){

                    string[] part = line.Split("**");
                    string goalType = part[0];
                    string goalInfo = part[1];

                    if(goalType == "SimpleGoal")
                    {
                        string[] goalParts = goalInfo.Split("|");
                        string goalName = goalParts[0];
                        string goalDescription = goalParts[1];
                        string goalPoints = goalParts[2];
                        bool goalComplete = bool.Parse(goalParts[3]);
                        SimpleGoal sg = new SimpleGoal(goalName, goalDescription, goalPoints, goalComplete);
                        _goalList.Add(sg);
                    } 
                    else if (goalType == "EternalGoal")
                    {
                        string[] goalParts = goalInfo.Split("|");
                        string goalName = goalParts[0];
                        string goalDescription = goalParts[1];
                        string goalPoints = goalParts[2];
                        EternalGoal eg = new EternalGoal(goalName, goalDescription, goalPoints);
                        _goalList.Add(eg);
                    } 
                    else if(goalType == "CheckListGoal")
                    {
                        string[] goalParts = goalInfo.Split("|");
                        string goalName = goalParts[0];
                        string goalDescription = goalParts[1];
                        string goalPoints = goalParts[2];
                        int goalBonusPoints = int.Parse(goalParts[3]);
                        int goalTarget= int.Parse(goalParts[4]);
                        int goalIsComplete = int.Parse(goalParts[5]);
                        CheckListGoal clg = new CheckListGoal(goalName, goalDescription, goalPoints, goalBonusPoints, goalTarget);
                        clg.SetAmountCompleted(goalIsComplete);
                        _goalList.Add(clg);
                    }

                }
            
            }else{

                Console.WriteLine($"The file {file} doesn't have any information!");
            }


        }else{

            Console.WriteLine($"The file {file} doesn't exist, please try another name!");
        }  
    }



    public void RecordEvent(){
       
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goalList){

            Console.WriteLine($"{_goalList.IndexOf(goal) + 1}. {goal.GetName}");
        }
        Console.Write("Which goal did you accomplish: ");
        int user = int.Parse(Console.ReadLine()) -1; 
        
        if (ResetGoal(user) == false){

            _goalList[user].RecordEvent();
            SetScore(int.Parse(_goalList[user].GetPoints));
            
        }
       
    }



    public void DisplayScore(){
    
        Console.WriteLine($"You now have {GetScore} Points.\n");
    }


    public bool ResetGoal(int selection){

        bool change = false;

        if (_goalList[selection].IsComplete()){

            Console.WriteLine("\nThis goal has already been completed. Would you like to reset it?");
            Console.Write("Type 'y' for yes or 'n' for no: ");
            string answer = Console.ReadLine();
            if (answer == "y"){

                _goalList[selection].SetComplete(false);

                Console.WriteLine();

                Console.WriteLine("Good thinking, your goal has been reset\n");

                ListGoalDetails();
                change = true;

            }else{

                RecordEvent();
                change = false;
            }
        }

        return change;
    }
 







}