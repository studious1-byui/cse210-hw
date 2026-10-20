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
        string userNumber;
        int userGuess;
        int numberOfGuesses = 0;
        string userResponse = "";
        
        do
        {
            // Generate random number between 1 and 100
            Random random = new Random();
            int magicNumber = random.Next(1, 101);
            
            // Reset variables if user wants to play again.
            userGuess = 0;
            numberOfGuesses = 0;
            userResponse = "";

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

                numberOfGuesses += 1;

                
            } while (userGuess != magicNumber);

            Console.WriteLine($"It took you {numberOfGuesses} guesses.");
            Console.Write("Do you want to play again? \"yes\" or \"no\" ");
            userResponse = Console.ReadLine();

        } while(userResponse == "yes");

    }
}