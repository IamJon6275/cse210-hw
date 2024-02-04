using System;

class PromptGenerator
{
    public string _prompt;
    public int _index;
    Random rnd = new Random();

    // Create a list of prompts
    public List<string> prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the tastiest thing I ate today?",
        "What was one kind thing I have done today?",
        "What was one kind thing that was done for me today?"
    };
    public PromptGenerator()
    {
    }

    // Generate a prompt from the list
    public string GeneratePrompt()
    {
        _index = rnd.Next(prompts.Count);
        _prompt = prompts[_index];
        return _prompt;
    }    
}