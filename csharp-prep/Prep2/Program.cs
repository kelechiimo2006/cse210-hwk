using System;

class Program
{
    static void Main(string[] args)
    {
        int grade;
        string letter;
        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine();
        grade = int.Parse(userInput);

        if (grade > 90 || grade == 90)
        {
            letter = "A";
        }
        else if (grade > 80 || grade == 80)
        {
            letter = "B";
        }
        else if (grade > 70 || grade == 70)
        {
            letter = "C";
        }
        else if (grade > 60 || grade == 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}");
    }
}