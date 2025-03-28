public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _timesCompleted;
    private int _totalTimes;
    public ChecklistGoal(string name, string description, int points, int totalTimes, int bonusPoints) : base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        _totalTimes = totalTimes;

    }
    public override void Display()
    {
        throw new NotImplementedException();
    }
    public override void isCompleted()
    {
        throw new NotImplementedException();
    }
    public override void SetCompleted()
    {
        throw new NotImplementedException();
    }

}