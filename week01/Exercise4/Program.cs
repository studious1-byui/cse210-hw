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
        
        List<int> numbers = new List<int>();   // List to add to numbers entered by user.
        string number = "";                    // string of number entered from console.
        int numberEntered;                     // int version of string number.
        int totalNumbersEntered = 0;           // All numbers added by user from console.
        double sum = 0;                        // Running total of numbers input from console.
        double average = 0;                    // Average of all numbers entered.

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        do
        {   
            // Prompt user for a non-zero number and add it to the numbers list.
            Console.Write("Enter number: ");
            number = Console.ReadLine();
            numberEntered = int.Parse(number);

            numbers.Add(numberEntered);

            sum += numberEntered;

            // If number entered is not zero add to total. Otherwise, ignore zero.
            if (numberEntered != 0)
            {
                totalNumbersEntered += 1;
            }
            else
            {
                totalNumbersEntered += 0;
            }

        } while (numberEntered != 0);

        // Compute average if total numbers entered by user is not zero.
        if (totalNumbersEntered != 0)
        {
            average = sum / totalNumbersEntered;    
        }

        // Output results.
        Console.WriteLine($"Sum: {sum} Total Numbers Entered: {totalNumbersEntered}");
        Console.WriteLine($"The average is: {average}");
    }
}