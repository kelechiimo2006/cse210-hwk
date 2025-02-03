using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program (With Classes)\n");
        
        Choice choice = new Choice();
        Menu menu = new Menu();
        Journal journal = new Journal();
        
        bool done = false;
        do{
            Console.WriteLine("");
            menu.Display();
            int choiceInt = choice.GetChoice();

            if (choiceInt == 1)
            {
                journal.AddEntry();
            } else if (choiceInt == 2)
            {
                journal.Display();
            } else if (choiceInt == 3)
            {
                journal.Load();
            } else if (choiceInt == 4)
            {
                journal.Save();
            } else if (choiceInt == 5)
            {
                done = true;
            }
        }while (!done);
    }
}