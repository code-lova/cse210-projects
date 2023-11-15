using System;
using System.Collections.Generic;


public class EternalGoal : Goal{

    public EternalGoal(string name, string points, string description) : base(name, points, description){

    }

    public override bool IsComplete()
    {
        return false;
    }


    public override void RecordEvent()
    {
        
    }

    public override void SetComplete(bool value)
    {

    }


    public override string GetStringRepresentation()
    {
        return $"EternalGoal**{GetName}|{GetDescription}|{GetPoints}";
    }

}