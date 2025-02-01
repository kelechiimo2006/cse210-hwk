using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,10);
        string userInput;
        int guess;
        
        do
        {
            
            Console.Write("What is your guess? ");
            userInput = Console.ReadLine();
            guess = int.Parse(userInput);
            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if(guess < number)
            {
                Console.WriteLine("Higher");
            }

        }while (guess != number);
        Console.WriteLine("You guessed it!");
    }
}