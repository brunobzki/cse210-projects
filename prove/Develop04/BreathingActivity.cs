using System;
using System.Threading;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity()
    {
        Name = "Breathing Activity";
        Description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        SetDuration();
        DisplayStartMessage();
        
        
    }

    public void PerformBreathingExercise()
    {   
        Console.WriteLine();
        Console.WriteLine("Get ready to start the breathing exercise.");
        Thread.Sleep(2000);

        for (int seconds = 0; seconds < Duration; seconds += 10)
        {
            int second = 5;
            string message = "Breathe in... ";
            ContDown(message, second);
            message = "Breathe out.. ";
            ContDown(message, second);

        }
        Console.Write("\r"+ new string(' ', Console.WindowWidth - 1));
        Thread.Sleep(2000);
        Console.WriteLine();

        Console.WriteLine("Congratulations! You've completed the Breathing Activity.");
        Thread.Sleep(2000);
    }


}