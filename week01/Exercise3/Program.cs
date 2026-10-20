/*
    Scott Christopher Severn
    W01 Exercise 3
    A random number guessing game.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise3 Project.");
        string number;
        string userNumber;
        int userGuess;
        
        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        do
        {
            Console.Write("What is your guess? ");
            userNumber = Console.ReadLine();
            userGuess = int.Parse(userNumber);

            if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
        } while (userGuess != magicNumber);

    }
}