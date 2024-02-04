using System;

class Journal
{
    public string _entry;
    public List<string> _journal = new List<string>();
    public bool _continue;
    public Journal()
    {
    }

    public bool HandleJournal(int _selector)
    {
        switch (_selector)
        {
            // Write a new entry and add it to the journal
            case 1:
                Entry ent = new Entry();
                ent.CompileEntry();
                _journal.Add(ent._entry);
                _continue = true;
                break;
            
            // Display all entries currently in the journal
            case 2:
                for (int i = 0; i < _journal.Count; i++)
                {
                    Console.WriteLine($"{_journal[i]}");
                }
                _continue = true;
                break;

            // Read all items from a file into the journal, replacing all current journal entries
            case 3:
                FileStuff rf = new FileStuff();
                _journal = rf.FileRead();
                _continue = true;
                break;

            // Write all items from the current journal into a file
            case 4:
                FileStuff wf = new FileStuff();
                wf.FileWrite(_journal);
                _continue = true;
                break;
            
            // End the program
            case 5:
                _continue = false;
                break;
        }
        return _continue;
    }
}