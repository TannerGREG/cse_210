using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();
        
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}. ");

        try
        {
            int numerator = 10;
            int denominator = 0;
            int result = numerator/denominator;
        }
        catch (Exception e)
        {
            Console.WriteLine("Oops something happened");
            Console.WriteLine (e.ToString());
        }
    }
}
/* 
whats up my dueds
*/