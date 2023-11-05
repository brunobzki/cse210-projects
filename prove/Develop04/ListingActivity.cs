using System;
using System.Collections.Generic;

public class ListingActivity : MindfulnessActivity
{
    public List<string> ListOfItems { get; set; }

    public ListingActivity()
    {
        Name = "Listing Activity";
        Description = "This activity consists of listing elements. You can write as much as you want about something, a moment or just your thoughts.";
        SetDuration();


    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"Prompt: ");
    }

    public void AddItemToList(string item)
    {
        ListOfItems.Add(item);
    }

    public void DisplayNumberOfItems()
    {
        Console.WriteLine($"Number of items listed: {ListOfItems.Count}");
    }



    
}