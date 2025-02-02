using System.IO; 

class Journal
{
    List <Entry> _entries = new List<Entry>();
    public void AddEntry()
    {
        Entry newEntry = new Entry();
        PromptGenerator randomPrompt = new PromptGenerator();
       
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
        }
        
        Console.WriteLine("======================");
    }
    public void Save()
    {
        Entry newEntry = new Entry();
        Console.Write("What is the file name? ");
        
        string fileName = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                string storedEntry = $"Date: {entry._date} - Prompt: {entry._prompt} \n{entry._response}";
                outputFile.WriteLine(storedEntry);        
            }
        }
    }

    public void Load()
    {
        Console.Write("What is the file name? ");
        
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