using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        PromptUserName(name);
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        PromptUserNumber(number);
        int t = SquareNumber(number);
        DisplayResult(t,name);
    }

        
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program");
    }
    static string PromptUserName(string name)
    {
        return name;
    }
    static int PromptUserNumber(int number)
    {
        return number;
    }
    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    } 
    static void DisplayResult(int squaredNumber, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
        
    
}