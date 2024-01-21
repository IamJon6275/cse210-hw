using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();

        string input;
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            input = Console.ReadLine();
            number = int.Parse(input);

            numbers.Add(number);
        } while(number != 0);

        int total = 0;

        foreach (int integer in numbers)
        {
            total += integer;
        }

        Console.WriteLine($"The sum is: {total}");

        float average = ((float)total) / (numbers.Count - 1);
        Console.WriteLine($"The average is: {Math.Round(average, 3)}");

        int max = 0;

        foreach (int integer in numbers)
        {
            if (integer > max)
            {
                max = integer;
            }
        }

        int maxpos = max;

        foreach (int integer in numbers)
        {
            if (integer < maxpos & integer > 0)
            {
                maxpos = integer;
            }
        }

        numbers.RemoveAt(numbers.Count() - 1);

        numbers.Sort();

        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {maxpos}");
        Console.WriteLine("The sorted list is: ");

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}