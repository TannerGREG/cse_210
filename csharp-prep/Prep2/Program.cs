using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("please insert your grade percentage: ");
        string percentageText = Console.ReadLine();
        int percentage = int.Parse(percentageText);

        string grade = "";
        string character = "";

        if (percentage >= 90)
        {
            grade = "A";
            if (percentage <= 93)
            {
                character = "-";
            }
            else
            {
                character = "";
            }
        }
        else if (percentage >= 80)
        {
            grade = "B";
            if (percentage >= 87)
            {
                character = "+";
            }
            else if (percentage <= 83)
            {
                character = "-";
            }
            else 
            {
                character ="";
            }
        }
        else if (percentage >= 70)
        {
            grade = "C";
            if (percentage >= 77)
            {
                character = "+";
            }
            else if (percentage <= 73)
            {
                character = "-";
            }
            else 
            {
                character ="";
            }
        }
        else if (percentage >= 60)
        {
            grade = "D";
            if (percentage >= 67)
            {
                character = "+";
            }
            else if (percentage <= 63)
            {
                character = "-";
            }
            else 
            {
                character ="";
            }
        }
        else
        {
            grade = "F";
            
        }

        Console.WriteLine($"You got a {grade}{character} ");

          if (percentage >= 70)
        {
            Console.WriteLine($"Congragulations you passed!");
        }
        else
        {
            Console.WriteLine("Sorry you didn't pass the class, better luck next time");
        }
    }
}