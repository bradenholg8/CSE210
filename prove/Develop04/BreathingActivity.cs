public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int durationInSeconds) : base("Breathing", durationInSeconds) { }

    public override void StartActivity()
    {
        base.StartActivity();
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000);
    }

    public override void PerformActivity()
    {
        for (int i = 0; i < durationInSeconds; i += 2)
        {
            Console.WriteLine("Breathe in...");
            PauseWithAnimation(1000);
            Console.WriteLine("Breathe out...");
            PauseWithAnimation(1000);
        }
    }
}
