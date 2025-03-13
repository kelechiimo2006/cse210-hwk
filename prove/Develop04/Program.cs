using System;

class Program
{
    
    static void Main(string[] args)
    {
        Menu menu = new Menu();
    
        int choiceInt = 0;
        while(choiceInt != 4)
        {
            Console.WriteLine("");
            menu.Display();
            choiceInt = menu.GetChoice();
            switch(choiceInt)
                {
                    case 1:
                    {
                        Console.Clear();
                        BreathingActivity b1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly.\nClear your mind and focus on your breathing.");
                        b1.StartActivity();

                        Console.Clear();
                        b1.GetReady();
                        b1.DisplayAnimation();
                        Console.WriteLine("\n\n");

                        b1.RunActivity();
                        b1.DisplayWellDone();
                        b1.EndActivity("Breathing Activity");
                        b1.DisplayAnimation();
                        Console.Clear();
                        break;
                    }
                    
                    case 2:
                    {
                        Console.Clear();
                        ReflectionActivity r1 = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.");
                        r1.StartActivity();
                        Console.Clear();
                        r1.GetReady();
                        r1.DisplayAnimation();
                        Console.WriteLine("");
                        r1.RunActivity();
                        r1.DisplayWellDone();
                        r1.EndActivity("Reflection Activity");
                        r1.DisplayAnimation();
                        Console.Clear();
                        break;
                    }
                    
                    case 3:
                    {
                        Console.Clear();
                        ListingActivity l1 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you \nlist as many things as you can in a certain area." );
                        l1.StartActivity();
                        Console.Clear();
                        l1.GetReady();
                        l1.DisplayAnimation();
                        l1.RunActivity();
                        l1.DisplayWellDone();
                        l1.EndActivity("Listing Activity");
                        l1.DisplayAnimation();
                        Console.Clear();
                        
                        break;
                    }
                    
                    
                }   
        }
                
    }
}