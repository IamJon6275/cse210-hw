using System;

class Program
{

    static void Main(string[] args)
    {
        // _selector is created to represent what the journal will do whe it's passed to the journal object
        int _selector;

        // _continue is set to true so the while loop can run once
        bool _continue = true;
        
        Journal j = new Journal();
        
        // Greet the user
        Console.WriteLine("Welcome to the Journal Program!");

        // While loop to call the different classes and loop the program until the user decides to quit
        while (_continue)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
            _selector = int.Parse(Console.ReadLine());

            
            _continue = j.HandleJournal(_selector);
        }
    }
}