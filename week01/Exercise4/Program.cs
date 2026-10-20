/*
    Scott Christopher Severn
    W01 Exercise 4
    Ask the user for a series of numbers,
    and append each one to a list. Stop when they enter 0.
*/
using System;
using System.Text.Json.Serialization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        string number = "";
        int numberEntered;
        int totalNumbersEntered = 0;
        double sum = 0;
        double average = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        do
        {
            Console.Write("Enter number: ");
            number = Console.ReadLine();
            numberEntered = int.Parse(number);

            numbers.Add(numberEntered);

            sum += numberEntered;

            if (numberEntered != 0)
            {
                totalNumbersEntered += 1;
            }
            else
            {
                totalNumbersEntered += 0;
            }

        } while (numberEntered != 0);

        if (totalNumbersEntered != 0)
        {
            average = sum / totalNumbersEntered;    
        }
        Console.WriteLine($"Sum: {sum} Total Numbers Entered: {totalNumbersEntered}");
        Console.WriteLine($"The average is: {average}");
    }
}