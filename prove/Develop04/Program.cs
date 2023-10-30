using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        Console.Write("+");

        Thread.Sleep(500);

        Console.Write("\b \b"); // Erase the + character
        Console.Write("*"); // Replace it with the - character
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("/"); // Replace it with the - character
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("+"); // Replace it with the - character
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character
    }
}