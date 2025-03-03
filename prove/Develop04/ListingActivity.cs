public class ListingActivity : Activity
{
    public ListingActivity(string name, string description) : base (name, description)
    {

    }
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _userInputs = new List<string>();

    public void RunActivity()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:\n");
    
        Random randomGenerator = new Random ();
        int _promptIndex = randomGenerator.Next(_prompts.Count);
        Console.WriteLine($"--- {_prompts[_promptIndex]} ---\n");

        Console.Write("You may begin in: ");
        DisplayCountdown();
        Console.WriteLine("");


        string userInput = "";
        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(GetDuration());
        
        while ((DateTime.Now < _endTime) && (userInput != "\n"))
        {
            Console.Write("> ");
            userInput = Console.ReadLine();
            _userInputs.Add(userInput);
        }

        Console.WriteLine("");

        Console.WriteLine($"You listed {_userInputs.Count()} items!");

    }
}