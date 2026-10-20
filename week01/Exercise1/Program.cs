/*
    Scott Christopher Severn
    W01 Exercise 1
    Reads a name from the console and prints a message.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise1 Project.");
        
        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();

        Console.WriteLine($"Your name is {lname}, {fname} {lname}");
    }
}