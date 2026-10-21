/*
    Scott Christopher Severn
    W01 Exercise 5
    For this assignment, write a C# program that has several simple functions:

    DisplayWelcome - Displays the message, "Welcome to the Program!"

    PromptUserName - Asks for and returns the user's name (as a string)

    PromptUserNumber - Asks for and returns the user's favorite number (as an integer)

    SquareNumber - Accepts an integer as a parameter and returns that number squared
    (as an integer)

    DisplayResult - Accepts the user's name and the squared number and displays them.

    Your Main function should then call each of these functions saving the 
    return values and passing data to them as necessary.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise5 Project.");

        // Displays the message, "Welcome to the Program!"
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        // Asks for and returns the user's name (as a string)
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            
            string userName = Console.ReadLine();

            return userName;
        }

        // Asks for and returns the user's favorite number (as an integer)
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");

            string favoriteNumberStr = Console.ReadLine();

            int favoriteNumber = int.Parse(favoriteNumberStr);

            return favoriteNumber;
        }

        // Accepts an integer as a parameter and returns that number squared
        // (as an integer)
        static int SquareNumber(int number)
        {
            int squared = number * number;
            
            return squared;
        }

        // Accepts the user's name and the squared number and displays them.
        static void DisplayResult(string userName, int square)
        {
            Console.WriteLine($"{userName}, the square of your number is {square}");
        }

        // Call each method with necessary parameters.
        DisplayMessage();

        // Get user name.
        string userNameEntered = PromptUserName();
        
        // Get user's favorite number.
        int userFavoriteNumber = PromptUserNumber();
        
        // Square user's favorite number.
        int userNumberSquared = SquareNumber(userFavoriteNumber);
        
        // Output results.
        DisplayResult(userNameEntered, userNumberSquared);
    }
}