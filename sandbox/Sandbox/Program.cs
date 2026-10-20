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
        //     Console.WriteLine("greater");
        // }

        // string school = "BYU-Idaho";
        // Console.WriteLine($"I am studying at {school}.");

        // int x = 5;
        // int y = 3;
        // int z = 3;

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
        //     Console.WriteLine("The name is John");
        // }

        // string favoriteColor = "sky blue";
        // string color = "";

        // Console.Write("Enter a color: ");
        // color = Console.ReadLine();
        // if (color != favoriteColor)
        // {
        //     Console.WriteLine($"{color} is not my favorite.");
        // }
        // else
        // {
        //     Console.WriteLine($"{color} is my favorite.");
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
        //     Console.WriteLine($"Welcome, Brother {fname}!");
        // }

        // if (!(fname == "Peter" || fname == "James" || fname == "John"))
        // {
        //     Console.WriteLine($"{fname} is not one of those three.");
        // }

        // Console.Write("Enter a number: ");
        // string valueInText = Console.ReadLine();
        // int number = int.Parse(valueInText);
        // Console.Write(number);
        
        // string textVersion = number.ToString();
        // Console.WriteLine(textVersion);

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

        List<int> numbers = new List<int>();
        
        List<string> words;
        words = new List<string>();

        words.Add("phone");
        words.Add("keyboard");
        words.Add("mouse");

        Console.WriteLine(words.Count);

        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }

        for (int i = 0; i < words.Count; i++)
        {
            Console.WriteLine(words[i]);
        }
    }
}