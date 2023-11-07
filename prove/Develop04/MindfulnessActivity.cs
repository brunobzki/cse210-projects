using System;
using System.Diagnostics;


public class MindfulnessActivity
{
    protected string Name { get; set; }
    protected string Description { get; set; }
    protected int Duration { get; set; }

    protected MindfulnessActivity()
    {
        Name = "Default Activity";
        Description = "This is a default activity.";
        Duration = 0;
    }
    public void ContDown(string message, int seconds)
    {
        Console.Write(message);
        for (int index = seconds; index > 0; index--)
        {
            Console.Write(index);
            Thread.Sleep(1000);
            Console.Write("\b");

        }
        Console.Write("\r");
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"\nStart {Name} ");
        Console.WriteLine($"\nDescription: {Description}");
        Console.WriteLine($"\nDuration: {Duration} seconds");
        Thread.Sleep(5000);
        Console.WriteLine();

    }

    public void SetDuration()
    {
        Console.WriteLine("How long, in seconds, would you like for the session?");
        Duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine($"\nCongratulations! You've completed the {Name}.");
        Console.WriteLine($"Duration of the activity: {Duration} seconds");

    }
    public void DisplaySpinner()
    {


        for (int i = 0; i < Duration; i++)
        {
            if (i >= Duration)
                break;

            Console.Write("  /  "); Thread.Sleep(250); Console.Write("\r");
            Console.Write("  -  "); Thread.Sleep(250); Console.Write("\r");
            Console.Write("  \\  "); Thread.Sleep(250); Console.Write("\r");
            Console.Write("  |  "); Thread.Sleep(250); Console.Write("\r");

        }

    }
    public void RunActivity(Action displayActivity)
    {
        do
        {
            displayActivity();
            Console.WriteLine("Would you like to repeat the activity? (yes/no)");
            string response = Console.ReadLine().ToLower();
            if (response != "yes")
            {
                Console.WriteLine("Activity completed. Goodbye!");
                break;
            }
        } while (true);
    }
}
