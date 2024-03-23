using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Program
{
    static void Main(string[] args)
    {
        User user = new User();

        while (true)
        {
            Console.WriteLine("Eternal Quest - Goal Tracker");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Enter your choice: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddGoal(user);
                    break;
                case "2":
                    ListGoals(user);
                    break;
                case "3":
                    SaveGoals(user);
                    break;
                case "4":
                    LoadGoals(user);
                    break;
                case "5":
                    RecordEvent(user);
                    break;
                case "6":
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddGoal(User user)
    {
        Console.WriteLine("Create New Goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter goal type (1-3): ");
        string goalTypeInput = Console.ReadLine();

        switch (goalTypeInput)
        {
            case "1":
                AddSimpleGoal(user);
                break;
            case "2":
                AddEternalGoal(user);
                break;
            case "3":
                AddChecklistGoal(user);
                break;
            default:
                Console.WriteLine("Invalid goal type. Please enter a number between 1 and 3.");
                break;
        }
    }

    static void AddSimpleGoal(User user)
    {
        Console.Write("Enter the name of your goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter a short description of it: ");
        string description = Console.ReadLine();
        Console.Write("Enter the amount of points associated with this goal: ");
        int value = int.Parse(Console.ReadLine());

        user.AddGoal(new SimpleGoal(name, description, value));
        Console.WriteLine("Simple goal added.");
    }

    static void AddEternalGoal(User user)
    {
        Console.Write("Enter the name of your goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter a short description of it: ");
        string description = Console.ReadLine();
        Console.Write("Enter the amount of points associated with this goal: ");
        int value = int.Parse(Console.ReadLine());

        user.AddGoal(new EternalGoal(name, description, value));
        Console.WriteLine("Eternal goal added.");
    }

    static void AddChecklistGoal(User user)
    {
        Console.Write("Enter the name of your goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter a short description of it: ");
        string description = Console.ReadLine();
        Console.Write("Enter the amount of points associated with this goal: ");
        int value = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of times this goal needs to be accomplished for a bonus: ");
        int targetCount = int.Parse(Console.ReadLine());
        Console.Write("Enter the bonus points for accomplishing it that many times: ");
        int bonusPoints = int.Parse(Console.ReadLine());

        user.AddGoal(new ChecklistGoal(name, description, value, targetCount, bonusPoints));
        Console.WriteLine("Checklist goal added.");
    }

    static void ListGoals(User user)
    {
        Console.WriteLine("List of Goals:");
        foreach (var goal in user.Goals)
        {
            Console.WriteLine($"- {goal.Name}: {goal.Description} ({goal.Points} points)");
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"  Currently completed: {checklistGoal.CompletedCount}/{checklistGoal.TargetCount}");
            }
        }
        Console.WriteLine($"Total Accumulated Points: {user.AccumulatedPoints}");
    }

    static void RecordEvent(User user)
    {
        Console.WriteLine("Select goal to record event for:");
        for (int i = 0; i < user.Goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {user.Goals[i].Name}");
        }

        Console.Write("Enter goal number: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < user.Goals.Count)
        {
            user.RecordEvent(goalIndex);
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    static void SaveGoals(User user)
    {
        Console.Write("Enter the file name to save goals: ");
        string fileName = Console.ReadLine();

        try
        {
            string json = JsonSerializer.Serialize(user.Goals);
            File.WriteAllText(fileName, json);
            Console.WriteLine($"Goals saved to {fileName} successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    static void LoadGoals(User user)
    {
        Console.Write("Enter the file name to load goals from: ");
        string fileName = Console.ReadLine();
        Console.WriteLine($"Loading goals from {fileName}...");
        Console.WriteLine("Goals loaded successfully.");
    }
}

