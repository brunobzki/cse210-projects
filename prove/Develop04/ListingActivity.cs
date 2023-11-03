using System;
using System.Collections.Generic;

public class ListingActivity : MindfulnessActivity
{
    public List<string> ListOfItems { get; set; }

    public ListingActivity()
    {
        Name = "Listing Activity";
        Description = "This activity involves listing items.";
        SetDuration(); 
        ListOfItems = new List<string>();
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"Prompt: {prompt}");
    }

    public void AddItemToList(string item)
    {
        ListOfItems.Add(item);
    }

    public void DisplayNumberOfItems()
    {
        Console.WriteLine($"Number of items listed: {ListOfItems.Count}");
    }

    public void DisplaySpinner()
    {
        // Agrega lógica para mostrar un spinner durante las pausas.
    }

    // Puedes agregar otros métodos y atributos específicos para la actividad de enumeración si es necesario.
}