using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Sandbox Project.");

        // int x = 5;
        // Console.WriteLine(x);
        // Console.WriteLine("Hello World!");

        // Console.Write("There will not be a newline after this.");

        // Console.Write("What is your favorite color? ");
        // string color = Console.ReadLine();
        // Console.WriteLine(color);

        // int y = 3;
        // if (x > y)
        // {
        //     Console.WriteLine("greater than");
        // }

        // string school = "BYU-Idaho";
        // Console.WriteLine($"I am studying at {school}.");

        // int x = 5;
        // int y = 3;
        // int z = 3;

        // if (x > y)
        // {
        //     if (x > z)
        //     {
        //         Console.WriteLine("greater than both.");
        //     }
        // }
        
        // if (x > y)
        // {
        //     Console.WriteLine("greater than");
        // }
        // else
        // {
        //     Console.WriteLine("less than");
        // }

        // if (x > y)
        // {
        //     Console.WriteLine("greater than y");
        // }
        // else if (x > z)
        // {
        //     Console.WriteLine("greater than z");
        // }
        // else
        // {
        //     Console.WriteLine("less than both");
        // }

        // string name = "John";
        // if (name == "John")
        // {
        //     Console.WriteLine($"The name is {name}");
        // }

        // string favoriteColor = "sky blue";
        // if (color != favoriteColor)
        // {
        //     Console.WriteLine("That color is not my favorite");
        // }

        // Console.Write("Enter your first name: ");
        // string fname = Console.ReadLine();
        // Console.Write("Enter your last name: ");
        // string lname = Console.ReadLine();

        // if (fname == "Peter" || fname == "James" || fname == "John")
        // {
        //     Console.WriteLine($"{fname} is a biblical name.");
        // }

        // if (fname == "Brigham" && lname == "Young")
        // {
        //     Console.WriteLine("Welcome Brother Brigham!");   
        // }

        // else if (!(fname == "Peter" || fname == "James" || fname == "John"))
        // {
        //     Console.WriteLine("This is not one of those three.");
        // }
        
        // string valueInText = "42";
        // int number = int.Parse(valueInText);

        Console.Write("Enter your favorite number: ");
        string valueInText = Console.ReadLine();
        int number = int.Parse(valueInText);
        Console.WriteLine(number);

        string textVersion = number.ToString();
        Console.WriteLine(textVersion);

        // string response = "yes";

        // while (response == "yes")
        // {
        //     Console.Write("Do you want to continue? ");
        //     response = Console.ReadLine();
        // }

        // string response;

        // do
        // {
        //     Console.Write("Do you want to continue? ");
        //     response = Console.ReadLine();
        // } while (response == "yes");

        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // for (int i = 2; i <= 20; i = i + 2)
        // {
        //     Console.WriteLine(i);
        // }

        // string[] colors = ["red", "green", "blue"];

        // foreach (string color in colors)
        // {
        //     Console.WriteLine(color);
        // }

        // Random randomGenerator = new Random();
        // int number = randomGenerator.Next(1, 11);
        
        // while (number != 10)
        // {
        //     Console.WriteLine(number);
        //     number = randomGenerator.Next(1, 11);
        // }

        // List<int> numbers = new List<int>();
        
        // List<string> words;
        // words = new List<string>();

        // words.Add("phone");
        // words.Add("keyboard");
        // words.Add("mouse");

        // Console.WriteLine(words.Count);

        // // foreach (string word in words)
        // // {
        // //     Console.WriteLine(word);
        // // }

        // for (int i = 0; i < words.Count; i++)
        // {
        //     Console.WriteLine(words[i]);
        // }
        // static void DisplayMessage()
        // {
        //     Console.WriteLine("Hello World!");
        // }

        // static void DisplayPersonalMessage(string userName)
        // {
        //     Console.WriteLine($"Hello {userName}");
        // }

        // static int AddNumbers(int first, int second)
        // {
        //     int sum = first + second;
        //     return sum;
        // }
    }
}