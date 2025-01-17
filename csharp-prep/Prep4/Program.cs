using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        List<int> numbers = new List<int>();
        string userInput;
        int number;
        do
        {
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            number = int.Parse(userInput);
            if(number != 0)
            {
                numbers.Add(number);
            }
            
        
        }while(number != 0 );
        int sum = numbers.Sum();
        double average = sum / numbers.Count();
        int max = numbers.Max();

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The average number is: {max}");


    }
}