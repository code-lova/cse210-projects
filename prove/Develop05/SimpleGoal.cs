using System;
using System.Collections.Generic;

public class SimpleGoal : Goal{

    private bool _isComplete = false;


    public SimpleGoal(string name, string description, string points, bool isComplete = false) : base(name, description, points){

        _isComplete = isComplete;

    }


    public override bool IsComplete()
    {
        return _isComplete;
    }


    public override void RecordEvent()
    {
        _isComplete = true;
    }


    public override void SetComplete(bool value)
    {
        _isComplete = value;
    }
    


    public override string GetStringRepresentation()
    {
        return $"SimpleGoal**{GetName}|{GetDescription}|{GetPoints}|{IsComplete()}";

    }

}