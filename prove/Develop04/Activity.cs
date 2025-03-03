using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

public Activity(string name, string description)
{
    _name = name;
    _description = description;
    
}
public void GetReady()
{
    Console.WriteLine("Get Ready...");
}
public void DisplayAnimation()
{
    List<string> _animationStrings = new List<string>(){"—", "|", "\\", "/", "—", "|", "\\", "/" };
    DateTime _startTime = DateTime.Now;
    DateTime _endTime = _startTime.AddSeconds(5);
    int i = 0;
    while (DateTime.Now < _endTime)
    {
        string s = _animationStrings[i];
        Console.Write(s);
        Thread.Sleep(500);
        Console.Write("\b \b");

        i++;

        if (i >= _animationStrings.Count())
        {
            i = 0;
        }
    }
    
}
public void DisplayCountdown()
{
    for (int i = 5; i > 0; i--)
    {
        Console.Write(i);
        Thread.Sleep(500);
        Console.Write("\b \b");
    }
}
public void StartActivity()
{
    Console.WriteLine($"Welcome to the {_name}");
    Console.WriteLine("");
    Console.WriteLine(_description);
    Console.WriteLine("");
    Console.Write("How long, in seconds, would you like for your session? ");
    _duration = int.Parse(Console.ReadLine());
    Console.Clear();
}
public int GetDuration()
{
    return _duration;
}
public void DisplayWellDone()
{
    Console.WriteLine("Well done!!");
}
public void EndActivity(string activityName)
{
    Console.WriteLine($"You have completed {_duration} seconds of the {activityName} ");
}
}
