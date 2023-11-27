using System;
using System.Collections.Generic;
using System.Globalization;


class SimpleGoal : Activity
{
    public SimpleGoal(string name, int targetValue, DateTime deadline) : base(name, GoalType.Simple, targetValue, deadline) { }

    public override void UpdateProgress(int value)
    {
        CurrentValue += value;

        if (CurrentValue >= TargetValue)
        {
            Completed = true;
            CurrentValue = TargetValue;
        }
    }
}

