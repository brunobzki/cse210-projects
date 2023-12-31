using System;
using System.Collections.Generic;

public class ListingActivity : MindfulnessActivity
{
    public List<string> ListOfItems { get; private set; }

    public ListingActivity()
    {
        Name = "Listing Activity";
        Description = "This activity will help you reflect on the good things in your life by listing as many things as you can in a certain area.";
        ListOfItems = new List<string>();
        SetDuration();
        DisplayStartMessage();
        RunActivity(EnumerateItemsWithCustomTime);
        DisplayEndMessage();
    }

    public string GetRandomPrompt()
    {

        string[] prompts =
        {
            "When have you felt the Holy Ghost this month?",
            "Ways you can be a disciple of Christ?",
            "Ways I can serve others?",
        };

        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];

    }

    public void EnumerateItemsWithCustomTime()
    {
        Console.WriteLine("The promt is:");
        if (Duration > 0)
        {
            var startTime = DateTime.Now;
            var endTime = startTime.AddSeconds(Duration);

            string prompt = GetRandomPrompt();
            List<string> items = new List<string>();

            Console.WriteLine(prompt);
            Console.WriteLine("Press Enter to start.");
            Console.ReadLine();
            Console.WriteLine("The timer has started!");

            while (DateTime.Now < endTime)
            {

                if (DateTime.Now >= endTime)
                    break;
                string item = Console.ReadLine();
                items.Add(item);
            }

            Console.WriteLine("\bTime's up! Your items:");

            foreach (var item in items)
            {
                DisplayItem(item);
            }
        }
        else
        {
            Console.WriteLine("Invalid duration. Please enter a positive number of seconds.");
        }
    }
    private void DisplayItem(string item)
    {
        Console.WriteLine($"- {item}");
    }


}