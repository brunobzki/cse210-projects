using System;
using System.Globalization;

class EternalGoal : Activity
{

    public EternalGoal(string name, int targetValue, DateTime deadline) : base(name, GoalType.Eternal, targetValue, deadline) { } 

    public override void UpdateProgress(int value)
    {
        CurrentValue += value;
        TimesCompleted++; 
    }
}