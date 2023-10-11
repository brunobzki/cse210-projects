using System;
using System.Collections.Generic;



class Program
{   private static List<Entry> entries = new List<Entry>();
    static void Main(string[] args)
    {
        

        Console.WriteLine("Welcome to the journal online!!");
        Journal journal = new Journal();
        journal.DisplayMenu();
  
        int userNumber=journal.PromptUserNumber();
        
        
        
        while (userNumber != 5)
        {
            if (userNumber == 1)
            {
                //Call the prompt generator class
                PromptGenerator promptGenerator = new PromptGenerator();
                string randomPrompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine("\nRandom Journal Prompt:");
                Console.WriteLine(randomPrompt);
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                string userResponse = Console.ReadLine();

                // Create an entry with the random prompt and user's response
                Entry entry = new Entry(date, randomPrompt, userResponse);

                // Add the entry to the entries list
                entries.Add(entry);
               
            }

            if (userNumber == 2)
            {
                //Display all entries of the Entry list
                Console.WriteLine("\nJournal Entries:\n");
                foreach (var entry in entries)
                {
                    Console.WriteLine(entry.GetDisplay());
                }
                
            }
            if (userNumber == 3)
            {
                // Load entries from file
                journal.LoadEntriesFromFile(entries);
            
            }

            if (userNumber == 4)
            {
                // Save entries to a file
                journal.SaveEntriesToFile(entries);
                
            }
            // Get the user's choice for the next iteration
            journal.DisplayMenu();
            userNumber = journal.PromptUserNumber();

        }
        // Option 5: Exit the program
        Console.WriteLine("Exiting the program. Goodbye!");
    }    
}