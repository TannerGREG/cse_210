using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 1;
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string numberInput = Console.ReadLine();
            number = int.Parse(numberInput);
            numbers.Add(number);
        }
        numbers.Remove(0);
        int sum = 0;
        int large = 0;
        foreach (int num in numbers)
        {
            sum += num;
            if (num > large)
                large = num;
        }
        float average = (float)sum / numbers.Count;


        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is is: {large}");

        
    }
}