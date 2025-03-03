class BreathingActivity : Activity

{
    private List<string> _prompts = new List<string>()
    {
        "Breathe in...",
        "Now breath out..."
    };
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }
    public void RunActivity()
    {
        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(GetDuration());
        
        while (DateTime.Now < _endTime)
        {
            Console.Write(_prompts[0]);
            DisplayCountdown();
            Console.WriteLine("");

            Console.Write(_prompts[1]);
            DisplayCountdown();
            Console.WriteLine("");
            Console.WriteLine("");
        }
        
    }
}