 class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string _name;

public void Display()
    {
        Console.WriteLine($"Name: {_name} \nDate: {_date} - Prompt: {_prompt} \n{_response}");
    }
}
