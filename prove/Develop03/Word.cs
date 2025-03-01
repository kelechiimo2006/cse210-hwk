class Word
{
    private List<string> _words = new List<string>()
    {"Trust","in","the","Lord","with","all","thine","heart;","and","lean","not","unto","thine","own","understanding.",
    "In","all","thy","ways","acknowledge","him,","and","he","shall","direct","thy","paths."};
    public string HideWord()
    {
        Random randomGenerator = new Random ();
        int _wordsIndex = randomGenerator.Next(_words.Count);
        string hidden = "___";
        _words[_wordsIndex] = hidden;
        stringHidden = string.Join(" ", _words);
        Console.WriteLine(stringHidden);
    }
}