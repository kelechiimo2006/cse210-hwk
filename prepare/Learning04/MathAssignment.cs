using System;
public class MathAssignment : Assignment

{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string textbookSection, string problem ) : base(name, topic)
    {
        _textbookSection = textbookSection;
        _problems = problem;
    }
    public string GetHomeworkList()
    {
        string text = $"{_textbookSection}, {_problems}";
        return text;
    }

}