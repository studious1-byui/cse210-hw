/*
    Scott Christopher Severn
    W01 Exercise 4
    Ask the user for a series of numbers,
    and append each one to a list. Stop when they enter 0.
    Core Requirements
    1. Compute the sum, or total, of the numbers in the list.
    2. Compute the average of the numbers in the list.
    3. Find the maximum, or largest, number in the list.
*/
using System;
using System.Text.Json.Serialization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise4 Project.");
        
        List<double> numbers = new List<double>(); // List to add to numbers entered by user.
        string number = "";                    // string of number entered from console.
        double numberEntered;                  // double version of string number.
        int totalNumbersEntered = 0;           // All numbers added by user from console.
        double sum = 0;                        // Running total of numbers input from console.
        double average = 0;                    // Average of all numbers entered.
        double largestNumberSoFar = 0;         // Holds the largest number added to the list.

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        do
        {   
            // Prompt user for a non-zero number and add it to the numbers list.
            Console.Write("Enter number: ");
            number = Console.ReadLine();
            numberEntered = double.Parse(number);

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

        // Find the maximum, or largest, number in the list.
        foreach (double enteredNumber in numbers)
        {
            if (enteredNumber > largestNumberSoFar)
            {
                largestNumberSoFar = enteredNumber;
            }
        }

        // Compute average if total numbers entered by user is not zero.
        if (totalNumbersEntered != 0)
        {
            average = sum / totalNumbersEntered;    
        }

        // Output results.
        Console.WriteLine($"Largest Number: {largestNumberSoFar}");
        Console.WriteLine($"Sum: {sum} Total Numbers Entered: {totalNumbersEntered}");
        Console.WriteLine($"The average is: {average}");
    }
}