using System;

public class Entry
{
    // Attributes
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    // Constructor
    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    // Method to get display string
    public string GetDisplay()
    {
        string display = $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}";
        return display;
    }
}