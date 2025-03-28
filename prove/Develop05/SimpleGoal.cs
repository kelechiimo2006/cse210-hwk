public class SimpleGoal : Goal
{
    
    private bool _done = false;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }

    public override void Display()
    {   
        if (_done == false)
        {
            Console.WriteLine($"[ ]{_name} ({_description})");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"[X]{_name} ({_description})");
            Console.WriteLine();
        }
    }
    public override void isCompleted()
    {
        
    }
    public override void SetCompleted()
    {
        _done = true;
    }
}