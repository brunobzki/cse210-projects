using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        string decision = ""; 

        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("Do you want to play a Magic Number game? (yes/no)");
        decision = Console.ReadLine();

        while (decision == "yes")
        {

            int user= -1;
        

        
            while (user != number)
            {
                Console.WriteLine("What is the number");
                user = int.Parse(Console.ReadLine());
                if (number>user)
                {
                    Console.WriteLine("Higher");
                }
                else if(number<user)
                {
                    Console.WriteLine("Lower");
                }
                else {
                    
                    Console.WriteLine("It's correct!!");
                    Console.WriteLine("Do you want to play a Magic Number game? (yes/no)");

                    decision = Console.ReadLine();
                }
                
            }
 
        }
        
        Console.WriteLine("You are so boring!!");
    }


}
   //import random

//decision = input("Do you want to play a Magic Number game? (yes/no)")
    
    
//while decision.lower() == ("yes"):
//    user = float(input ("What is the number??"))
//    number = random.randint(1,9)

//    while number != user:
//        print("Sorry try again")
//        if number < user:
//            print("Lower..")
//            user = float(input ("What is the number??"))
//        if number > user:
//            print("Higer..")
//            user = float(input ("What is the number??"))
//
//    print()
//    print("congatulation")
//    print()
//    print (f"The correct number was: {number}")
//    print()
//    decision = input("Do you want play a Magic Number game? (yes/no)")  

//print()
//print("You are so boring...") 
//print()   






