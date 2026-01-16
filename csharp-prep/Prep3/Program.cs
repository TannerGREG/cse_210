using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the majic number? ");
        // string magicString = Console.ReadLine();
        // int magicNum = int.Parse(magicString);
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1,100);
        int guess;
        do
        {
            Console.WriteLine("What is your guess? ");
            string guessString = Console.ReadLine();
            guess = int.Parse(guessString);
            if (magicNum > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNum == guess)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Lower");
            }
        } while (guess != magicNum);
    }
}