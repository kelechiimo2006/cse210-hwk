using System;

class Program
{
    static void Main(string[] args)
    {
        Word word = new Word();
        string text = word.HideWord();
        Console.Write("Enter: ");
        string input = Console.ReadLine();

        while (input != "quit")
        {
            Console.WriteLine(text);
            Console.ReadLine();
            Console.Clear();
        }
    }
}