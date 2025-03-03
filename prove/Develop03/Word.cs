using System.ComponentModel.DataAnnotations;

class Word
{
    
    public string HideWord()
    {
        Random randomGenerator = new Random ();
        int _wordsIndex = randomGenerator.Next(_words.Count);
        string hidden = "___";
        for (int i = 0; i <= _words(_wordsIndex).Length;i++)
        {
            Console.WriteLine("_");
        }
        _words[_wordsIndex] = hidden;
        string stringHidden = string.Join(" ", _words);
        return stringHidden;
    }
}