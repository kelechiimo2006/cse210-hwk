class Menu

{
    public void Display()
    {
        Console.WriteLine("Please select one of the following options: ");
        Console.WriteLine("1) Breathing Activity");
        Console.WriteLine("2) Listing Activity");
        Console.WriteLine("3) Reflection Activity");
        //Console.WriteLine("4) Save");
        Console.WriteLine("4) Quit");
        Console.WriteLine();
    }
    public int Choice()
    {
        Console.Write("Enter a choice: ");
        string choice = Console.ReadLine();
        return Convert.ToInt32(choice);
    }
}
