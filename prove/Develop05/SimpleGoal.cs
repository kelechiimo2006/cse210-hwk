public class SimpleGoal : Goal
{
    
    
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }

    public override void Display()
    {
            Console.WriteLine($"{_name} {_description}");
            Console.WriteLine();
    }
    public override void isCompleted()
    {
        throw new NotImplementedException();
    }
}