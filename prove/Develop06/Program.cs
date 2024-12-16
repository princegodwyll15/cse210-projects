using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var goals = new List<Goal>();
        Console.WriteLine("Welcome to the Eternal Quest program!");

        while (true)
        {
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event for a goal");
            Console.WriteLine("3. View all goals");
            Console.WriteLine("4. Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(goals);
                    break;
                case "2":
                    RecordEventForGoal(goals);
                    break;
                case "3":
                    ViewAllGoals(goals);
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void CreateNewGoal(List<Goal> goals)
    {
        Console.WriteLine("\nWhat type of goal would you like to create?");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");

        var choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                CreateSimpleGoal(goals);
                break;
            case "2":
                CreateEternalGoal(goals);
                break;
            case "3":
                CreateChecklistGoal(goals);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    private static void CreateSimpleGoal(List<Goal> goals)
    {
        Console.Write("Enter the name of the goal: ");
        var name = Console.ReadLine();
        Console.Write("Enter the points for the goal: ");
        var points = int.Parse(Console.ReadLine());

        goals.Add(new SimpleGoal(name, points));
        Console.WriteLine($"Simple goal '{name}' created successfully!");
    }

    private static void CreateEternalGoal(List<Goal> goals)
    {
        Console.Write("Enter the name of the goal: ");
        var name = Console.ReadLine();
        Console.Write("Enter the points for the goal: ");
        var points = int.Parse(Console.ReadLine());

        goals.Add(new EternalGoal(name, points));
        Console.WriteLine($"Eternal goal '{name}' created successfully!");
    }

    private static void CreateChecklistGoal(List<Goal> goals)
    {
        Console.Write("Enter the name of the goal: ");
        var name = Console.ReadLine();
        Console.Write("Enter the points for each completion: ");
        var points = int.Parse(Console.ReadLine());
        Console.Write("Enter the target count for the checklist goal: ");
        var targetCount = int.Parse(Console.ReadLine());

        goals.Add(new ChecklistGoal(name, points, targetCount));
        Console.WriteLine($"Checklist goal '{name}' with a target of {targetCount} completions created successfully!");
    }

    private static void RecordEventForGoal(List<Goal> goals)
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals have been created yet.");
            return;
        }

        Console.WriteLine("\nSelect a goal to record an event for:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }

        var choice = int.Parse(Console.ReadLine());
        if (choice > 0 && choice <= goals.Count)
        {
            goals[choice - 1].RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }

    private static void ViewAllGoals(List<Goal> goals)
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals have been created yet.");
            return;
        }

        Console.WriteLine("\nHere are all the goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine($"- {goal.Name} ({goal.Points} points)");
            if (goal is SimpleGoal simpleGoal)
            {
                Console.WriteLine($"  Completed: {simpleGoal.IsCompleted}");
            }
            else if (goal is EternalGoal eternalGoal)
            {
                Console.WriteLine($"  Times recorded: {eternalGoal.TimesRecorded}");
            }
            else if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"  Progress: {checklistGoal.CurrentCount}/{checklistGoal.TargetCount}");
            }
        }
    }
}
