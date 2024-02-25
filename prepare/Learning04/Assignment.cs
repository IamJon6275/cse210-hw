using System;

public class Assignment
{
    protected string _studentName;
    private string _topic;

    public Assignment(string name, string top)
    {
        _studentName = name;
        _topic = top;
    }
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}