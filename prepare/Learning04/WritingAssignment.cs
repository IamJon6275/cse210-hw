using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string name, string top, string title) : base(name, top)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}