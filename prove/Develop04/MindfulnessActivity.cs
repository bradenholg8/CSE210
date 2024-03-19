using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    protected int durationInSeconds;
    protected string activityName;

    public MindfulnessActivity(string activityName, int durationInSeconds)
    {
        this.activityName = activityName;
        this.durationInSeconds = durationInSeconds;
    }

    public virtual void StartActivity()
    {
        Console.WriteLine($"Starting {activityName} activity...");
        Thread.Sleep(2000);
    }

    public virtual void EndActivity()
    {
        Console.WriteLine($"Congratulations! You've completed the {activityName} activity.");
        Console.WriteLine($"You've spent {durationInSeconds} seconds on {activityName}.");
        Thread.Sleep(2000);
    }

    protected void PauseWithAnimation(int milliseconds)
    {
        Thread.Sleep(milliseconds);
    }

    public abstract void PerformActivity();
}
