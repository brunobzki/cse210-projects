using System;
using System.Globalization;
class ChecklistGoal : Activity
{
    public ChecklistGoal(string name, int targetValue, int bonusPoints,DateTime deadline) : base(name, GoalType.Checklist, targetValue, deadline, bonusPoints) { }

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