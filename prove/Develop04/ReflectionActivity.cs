public class ReflectionActivity : Activity
{
    public  ReflectionActivity(string name, string description) : base (name, description)
    {

    }

    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
public void RunActivity()
{
    Console.WriteLine("Consider the following prompt:\n");
    
    Random randomGenerator = new Random ();
    int _promptIndex = randomGenerator.Next(_prompts.Count);
    Console.WriteLine($"--- {_prompts[_promptIndex]} ---\n");
    
    Console.WriteLine("When you have something in mind, press Enter to continue");
    Console.ReadLine();
    Console.WriteLine("");

    Console.WriteLine("Now, ponder on each of the following questions as they are relate to this experience.");

    Console.Write("You may begin in: ");
    DisplayCountdown();
    
    Console.Clear();

    DateTime _startTime = DateTime.Now;
    DateTime _endTime = _startTime.AddSeconds(GetDuration());
        
    while (DateTime.Now < _endTime)
    {
        int _questionsIndex = randomGenerator.Next(_questions.Count);
        Console.Write($"> {_questions[_questionsIndex]} ");
        DisplayAnimation();
        Console.WriteLine("");
        _questions.RemoveAt(_questionsIndex);

    }
    
    
}
}