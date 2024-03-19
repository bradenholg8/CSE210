public class ListingActivity : MindfulnessActivity
{
    private string[] prompts = {
    
    };

    public ListingActivity(int durationInSeconds) : base("Listing", durationInSeconds) { }

    public override void StartActivity()
    {
        base.StartActivity();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000);
    }

    public override void PerformActivity()
    {
        
    }
}
