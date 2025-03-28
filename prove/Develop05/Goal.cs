public abstract class Goal
{
    private int _points;
    protected string _name;
    protected string _description;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    //public void DisplayPoints(int points)
    public abstract void Display();
    public int GetPoints()
    {
        return _points;
    }
    public abstract void isCompleted();
    public string GetName()
    {
        return _name;
    }
    public abstract void SetCompleted();

    
    
}