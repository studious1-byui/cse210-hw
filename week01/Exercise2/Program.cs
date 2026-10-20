using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Enter your grade percentage: ");
        string grade = Console.ReadLine();
        float gradePercentage = float.Parse(grade);
        string letter = "";
        string message = "";
        string sign = "";

        // Determine plus grade sign based on if the last digit of earned grade is >= 7
        if (gradePercentage % 10 >= 7)
        {
            sign = "+";
        }
        // Determine minus grade sign based on if the last digit of earned grade is <= 3
        else if (gradePercentage % 10 <= 3)
        {
            sign = "-";
        }
        
        // Determine letter grade.
        if (gradePercentage >= 90)
        {
            letter = "A";
            if (gradePercentage <= 93)
            {
                sign = "-";
            }
            // There is no A+ letter grade so set sign to empty string.
            else
            {
                sign = "";
            }
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";   
        }
        else if (gradePercentage < 60)
        {
            letter = "F";
            // There are no F+ or F- grades, so set sign to empty string.
            sign = "";
        }

        // 70% required to pass class. 
        if (gradePercentage >= 70)
        {
            message = "Congratulations, you passed the course!";
        }
        // Student must retake course if grade is less than 70.
        else if (gradePercentage < 70)
        {
            message = "Improve your score next time. You got this.";
        }
        Console.WriteLine($"Earned grade: {letter}{sign}. {message}");
    }
}