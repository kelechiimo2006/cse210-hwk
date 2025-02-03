using System.IO; 

class Journal
{
    List <Entry> _entries = new List<Entry>();
    
    public void AddEntry()
    {
        Entry newEntry = new Entry();
        PromptGenerator randomPrompt = new PromptGenerator();
       
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        newEntry._name = name;

        string prompt = randomPrompt.GetRandomPrompt();
        newEntry._prompt = prompt;
        Console.WriteLine(prompt);
        
        Console.WriteLine("");

        string response = Console.ReadLine();
        newEntry._response = response;
        
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        newEntry._date = dateText;

        _entries.Add(newEntry);
    }
    
    public void Display()
    {
        Console.WriteLine("Entries: ");
        Console.WriteLine("======================");

        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine("");
        }
        
        Console.WriteLine("======================");
    }
    
    public void Save()
    {
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                string storedEntry = $"Name: {entry._name} \nDate: {entry._date} - Prompt: {entry._prompt} \n{entry._response}";
                outputFile.WriteLine(storedEntry);
                outputFile.WriteLine("");        
            }
        }
    }

    public void Load()
    {
        Console.Write("What is the file name? \n");
        string fileName = Console.ReadLine();
        string[] lines =  System.IO.File.ReadAllLines(fileName);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            
            foreach (string part in parts)
            {
            Console.WriteLine(part);
            }
        }
    }
}