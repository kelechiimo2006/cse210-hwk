using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment a1 = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(a1.GetSummary());
        MathAssignment m1 = new MathAssignment("Paul", "fraction", "section 2", "secton 1");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());
        WritingAssignment w1 = new WritingAssignment("", "fraction", "section 2");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
    }
}

