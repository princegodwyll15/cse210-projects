using System;
using System.Collections.Generic;
using System.IO;


public class Program
{
    private static int score = 0;
    private static List<Goal> goals = new List<Goal>();

    public static void Main()
    {
        Console.WriteLine("Welcome to the Eternal Quest program!");

        while (true)
        {
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine($"Score: {score}");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event for a goal");
            Console.WriteLine("3. View all goals");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Exit");


            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ViewGoals();
                    break;
                case "4":
                LoadGoals();
                    break;    
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void CreateGoal()
    {
        Console.WriteLine("\nWhat type of goal would you like to create?");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");

        var choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                CreateSimpleGoal();
                break;
            case "2":
                CreateEternalGoal();
                break;
            case "3":
                CreateChecklistGoal();
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    private static void CreateSimpleGoal()
    {
        Console.Write("Enter the name of the goal: ");
        var name = Console.ReadLine();
        Console.Write("Enter the points for the goal: ");
        var points = int.Parse(Console.ReadLine());

        goals.Add(new SimpleGoal(name, points));
        Console.WriteLine($"Simple goal '{name}' created successfully!");
    }

    private static void CreateEternalGoal()
    {
        Console.Write("Enter the name of the goal: ");
        var name = Console.ReadLine();
        Console.Write("Enter the points for the goal: ");
        var points = int.Parse(Console.ReadLine());

        goals.Add(new EternalGoal(name, points));
        Console.WriteLine($"Eternal goal '{name}' created successfully!");
    }

    private static void CreateChecklistGoal()
    {
        Console.Write("Enter the name of the goal: ");
        var name = Console.ReadLine();
        Console.Write("Enter the points for each completion: ");
        var points = int.Parse(Console.ReadLine());
        Console.Write("Enter the target count for the checklist goal: ");
        var targetCount = int.Parse(Console.ReadLine());

        goals.Add(new ChecklistGoal(name, points, targetCount));
        Console.WriteLine($"Checklist goal '{name}' created successfully!");
    }

    private static void RecordEvent()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals have been created yet.");
            return;
        }

        Console.WriteLine("\nSelect a goal to record an event for:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()} {goals[i].GetName()}");
        }

        var choice = int.Parse(Console.ReadLine());
        if (choice > 0 && choice <= goals.Count)
        {
            goals[choice - 1].RecordEvent(ref score);
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }

    private static void ViewGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals have been created yet.");
            return;
        }

        Console.WriteLine("\nHere are all your goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine($"{goal.GetStatus()} {goal.GetName()}");
        }
    }

    private static void SaveGoals()
    {
        Console.Write("Which name would you love to give to your file: ");
        string fileName = Console.ReadLine();
        using (var writer = new StreamWriter(fileName))
        {
            writer.WriteLine(score);
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.Serialize());
            }
        }
        Console.WriteLine("Goals and score saved successfully!");
    }

    private static void LoadGoals()
    {
        Console.Write("What's the name of the file you would love to load your goal from: ");
        string loadFile = Console.ReadLine();
        if (!File.Exists(loadFile)) return;

        using (var reader = new StreamReader(loadFile))
        {
            score = int.Parse(reader.ReadLine());
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                switch (parts[0])
                {
                    case "SimpleGoal":
                        goals.Add(SimpleGoal.Deserialize(parts));
                        break;
                    case "EternalGoal":
                        goals.Add(EternalGoal.Deserialize(parts));
                        break;
                    case "ChecklistGoal":
                        goals.Add(ChecklistGoal.Deserialize(parts));
                        break;
                }
            }
        }
        Console.WriteLine("Goals and score loaded successfully!");
    }
}
