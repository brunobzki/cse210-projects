using System;

public class MindfulnessActivity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; private set; }

    protected MindfulnessActivity()
    {
        Name = "Default Activity";
        Description = "This is a default activity.";
        Duration = 0;
    }
    public void ContDown(string message, int seconds)
    {   Console.Write(message);
            for(int index = seconds; index>0; index--)
            {
                Console.Write(index);
                Thread.Sleep(1000);
                Console.Write("\b");

            }
        Console.Write("\r");
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Start {Name} ");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Duration: {Duration} seconds");
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
        Console.WriteLine($"Congratulations! You've completed the {Name} Activity.");
        Console.WriteLine($"Duration: {Duration} seconds");
        // Puedes agregar aquí la lógica para mostrar un contador o animación de finalización.
    }
}
