using System;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.Arm;

class Program
{
    
    static void Main(string[] args)
    {
        Console.Clear();
        Menu menu = new Menu();
        int choiceInt = 0;
        List<Goal> Goals = new List<Goal>();
        while (choiceInt != 6)
        {
            menu.Display();
            choiceInt = menu.GetChoice();

            switch(choiceInt)
                {
                    case 1:
                    {
                        menu.DisplayGoalTypes();
                        int goalChoice = menu.GetGoalChoice();
                        switch(goalChoice)
                        {
                            case 1:
                            {
                                Console.Write("What is the name of your goal? ");
                                string name = Console.ReadLine();
                                Console.Write("What is a short description of it? ");
                                string description = Console.ReadLine();
                                Console.Write("What is the amount of points associated with this goal? ");
                                int points = Convert.ToInt32(Console.ReadLine());
                                SimpleGoal g1 = new SimpleGoal(name, description, points);
                                Goals.Add(g1);

                                break;
                            }
                            case 2:
                            {
                                Console.Write("What is the name of your goal? ");
                                string name = Console.ReadLine();
                                Console.Write("What is a short description of it? ");
                                string description = Console.ReadLine();
                                Console.Write("What is the amount of points associated with this goal? ");
                                int points = Convert.ToInt32(Console.ReadLine());
                                EternalGoal g2 = new EternalGoal(name, description, points);
                                Goals.Add(g2);
                                break;
                            }
                            case 3:
                            {
                                Console.Write("What is the name of your goal? ");
                                string name = Console.ReadLine();
                                Console.Write("What is a short description of it? ");
                                string description = Console.ReadLine();
                                Console.Write("What is the amount of points associated with this goal? ");
                                int points = Convert.ToInt32(Console.ReadLine());
                                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                                int totalTimes = Convert.ToInt32(Console.ReadLine());
                                Console.Write("What is the bonus for accomplishing it that many times? ");
                                int bonusPoints = Convert.ToInt32(Console.ReadLine());
                                ChecklistGoal g3 = new ChecklistGoal(name, description, points, totalTimes, bonusPoints );
                                Goals.Add(g3);
                                break;
                            }
                        }
                        break;
                    }
                    case 2:
                    {
                        foreach(Goal g in Goals)
                        {
                            g.Display();
                        }
                        break;
                    }
                    case 5:
                    {
                        int no = 0;
                        Console.WriteLine("The goals are: ");
                        foreach(Goal g in Goals)
                        {
                            no++;
                            Console.WriteLine($"{no}. {g.GetName()}");
                        }
                        break;
                    }
                }
        }
    }
}