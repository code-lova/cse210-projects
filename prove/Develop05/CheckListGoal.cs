using System;
using System.Collections.Generic;


public class CheckListGoal : Goal {

    private int _amountCompleted = 0;
    private int _target = 0;
    private int _bonus = 0;

    public CheckListGoal(string name, string points, string description, int bonus, int target) : base(name, points, description){

        _bonus = bonus;
        _target = target;

    }

    //Getters and setters
    public int GetAmountCompleted{

        get{ return _amountCompleted; }

    }

    public void SetAmountCompleted(int amountCompleted){

        _amountCompleted = amountCompleted;
    }

    public int GetTarget{

        get{ return _target; }

    }

    public int GetBonus{

        get{ return _bonus; }

    }

   

    public override bool IsComplete()
    {
        if(_amountCompleted == _target){

            return true;

        }else{
            
            return false;
        }
    }



    public override void RecordEvent()
    {
        _amountCompleted += 1;
        //If the goal is completed this will add the bonus to the point
        if (IsComplete() == true){

            int bonus = int.Parse(GetPoints) + _bonus;
            SetPoints(bonus.ToString());
        }
    }



    public override void SetComplete(bool value)
    {
        _amountCompleted = 0;
    }



     public override string GetDetailsString(){

        string status  = "[ ]";
        if(IsComplete() == true){

            status = "[X]";
        }
        return $"{status} {GetName} ({GetDescription}) -- Currently Completed: {GetAmountCompleted}/{GetTarget}";
    }



     public override string GetStringRepresentation(){

        return $"CheckListGoal**{GetName}|{GetDescription}|{GetPoints}|{GetBonus}|{GetTarget}|{GetAmountCompleted}";

    }
}