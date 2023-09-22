using System;
using System.Net.WebSockets;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        List<int> positives =  new List<int>();
        int new_number = -1;
        
        
        while (new_number!=0) 
        {

            Console.WriteLine("Enter a list of numbers, type '0' to stop.");
            new_number = int.Parse(Console.ReadLine());

            if (new_number== 0)
            {
                Console.WriteLine("Good bye!!");
                return;
                
            }

            else 
            {
                while (new_number != 0 )
                {
                    if (new_number !=0)
                    {
                        numbers.Add(new_number);

                        if (new_number>0)
                        {
                            positives.Add(new_number);
                        }

                    }
                Console.WriteLine("Enter a new numbers, type '0' to stop.");
                new_number = int.Parse(Console.ReadLine());
                }
            }

            int max = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    
                    max = number;
                }
            }

            Console.WriteLine($"The max is: {max}");


            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"The sum is: {sum}");

            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");


            int min = numbers[0];

            foreach (int number in numbers)
            {
                if (number < min)
                {
                    
                    min = number;
                }
            }

            Console.WriteLine($"The min is: {min}");

            foreach (int number in numbers)
            {
            Console.WriteLine(number);
            }
        }   



    }

}

//        numbers = []
//positives = []
//new_number=-1
//print()
//print('Enter a list of numbers, type "0" to stop.')
//print()
//
//new_number = int(input('Enter number: '))
//if new_number==0:
//    print("good bye")
//    exit
//while new_number !=0:
//    
//    if new_number != 0:
//       
//        numbers.append(new_number)
//        if new_number > 0:
//            positives.append(new_number)
//largest_number = max(numbers)
//adding = sum(numbers)
//quantity = len(numbers)
//avarage = adding / quantity
//order = sorted(numbers)
//tiny_number = min(positives)
//print(f'The sum of all numbers is {adding}.')
//print(f'The avarage is {avarage}.')
//print(f'The largest number is {largest_number}.')
//print(f'The smallests number is {tiny_number}.')
//print('The sorted list is:')
//for i in order:
//    print(i)
//        
//print('Good bye')       

