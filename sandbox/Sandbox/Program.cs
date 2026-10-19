using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");

        int x = 5;
        Console.WriteLine(x);
        Console.WriteLine("Hello World!");

        Console.Write("There will not be a newline after this.");

        Console.Write("What is your favorite color? ");
        string color = Console.ReadLine();
        Console.WriteLine(color);

        int y = 3;
        if (x > y)
        {
            Console.WriteLine("greater");
        }

        string school = "BYU-Idaho";
        Console.WriteLine($"I am studying at {school}.");
    }
}