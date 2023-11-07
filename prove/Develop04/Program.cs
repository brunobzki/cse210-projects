using System;

class Program
{

    static void Main(string[] args)
    {

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program Menu");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":

                    BreathingActivity breathingActivity = new BreathingActivity();
                    break;

                case "2":

                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    break;

                case "3":

                    ListingActivity listingActivity = new ListingActivity();
                    break;

                case "4":

                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }

            Console.WriteLine("\nPress Enter to return to the menu.");
            Console.ReadLine();
        }
    }
}