class Menu

{
    public void Display()
    {
        Console.Clear();
        Console.WriteLine("Please select one of the following options: ");
        Console.WriteLine("1) Breathing Activity");
        Console.WriteLine("2) Reflection Activity");
        Console.WriteLine("3) Listing Activity");
        Console.WriteLine("4) Quit");
        Console.WriteLine();
    }
    public int GetChoice()
    {
        Console.Write("Enter a choice: ");
        string choice = Console.ReadLine();
        return Convert.ToInt32(choice);
    }
}
