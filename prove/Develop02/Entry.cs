using System;

class Entry
{
    public string _entry;
    public string _entryText;
    public string _entryDate;
    public string _entryPrompt;
    public string _entryFname;
    public string _entryLname;
    public Entry()
    {
    }

    public string CompileEntry()
    {
        // Get the first name and last name of the enterer
        Console.Write("What is your first name? ");
        _entryFname = Console.ReadLine();

        Console.Write("What is your last name? ");
        _entryLname = Console.ReadLine();

        // Get a new prompt and save it to the variable _entryPrompt
        PromptGenerator _prompt = new PromptGenerator();
        _entryPrompt = _prompt.GeneratePrompt();
        Console.WriteLine(_entryPrompt);

        // Get the current date and save it to the variable _entryDate
        DateTime theCurrentTime = DateTime.Now;
        _entryDate = theCurrentTime.ToShortDateString();

        // Display the prompt and write the entry
        Console.Write("> ");
        _entryText = Console.ReadLine();

        // Compile and return the entry
        _entry = $"Entry by: {_entryLname}, {_entryFname}\nDate: {_entryDate} - Prompt: {_entryPrompt}\n{_entryText}|";
        return _entry;
    }
}