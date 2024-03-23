using System;
using System.Collections.Generic;

public class User
{
    public List<Goal> Goals { get; private set; }
    public int AccumulatedPoints { get; private set; }

    public User()
    {
        Goals = new List<Goal>();
        AccumulatedPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < Goals.Count)
        {
            Goal goal = Goals[goalIndex];

            if (goal.IsComplete)
            {
                Console.WriteLine("This goal has already been completed.");
                return;
            }

            goal.RecordEvent();

            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete)
            {
                AccumulatedPoints += checklistGoal.Points + checklistGoal.BonusPoints;
            }
            else
            {
                AccumulatedPoints += goal.Points;
            }

            Console.WriteLine($"Congratulations! You have earned {goal.Points} points!");
            Console.WriteLine($"You now have {AccumulatedPoints} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }
}
