public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description): base(name, description)
    {}
    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write($"Breathe in...");
            Console.WriteLine(ShowCountDown(4));
            Console.Write($"Now breathe out...");
            Console.WriteLine(ShowCountDown(6));
            Console.WriteLine();
        }
    }
}