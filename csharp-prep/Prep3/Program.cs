using System;

class Program
{
    static void Main(string[] args)
    {
        string response;
        do
        {
            // Console.WriteLine("Hello Prep3 World!");
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);

            // Console.WriteLine($"Your random number is {number}");

            bool guessed = false;
            int turns = 1;
            while (guessed == false)
            {
                Console.Write("Please enter your guess (between 1 and 100): ");
                int answer = int.Parse(Console.ReadLine());
                if (answer > number)
                {
                    Console.WriteLine("Lower");
                    turns += 1;
                }
                else if (answer < number)
                {
                    Console.WriteLine("Higher");
                    turns += 1;
                }
                else
                {
                    Console.WriteLine("Correct!");
                    guessed = true;
                }
            }
            Console.WriteLine($"it took you {turns} turns to guess the number");
            // Console.WriteLine($"They guessed {answer}");
            Console.Write("Do you want to play again (yes/no)? ");
            response = Console.ReadLine();
            response.ToLower();
        } while (response == "yes");
    }
}