class Menu

{
    public void Display()
    {
        //Console.Clear();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("  1) Create New Goal");
        Console.WriteLine("  2) List Goals");
        Console.WriteLine("  3) Save Goals");
        Console.WriteLine("  4) Load Goals");
        Console.WriteLine("  5) Record Event");
        Console.WriteLine("  6) Quit");
        Console.WriteLine();
    }
    public int GetChoice()
    {
        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();
        return Convert.ToInt32(choice);
    }

    public void DisplayGoalTypes()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
    }

    public int GetGoalChoice()
    {
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();
        return Convert.ToInt32(choice);
    }
}