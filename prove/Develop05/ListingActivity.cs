public class ListingActivity : Activity
{
    List<string> _prompts;
    Random _random;
    public ListingActivity(string name, string description): base(name,description)
    {}
    public void Run()
    {
        List<string> lists = new List<string>(); 
        DateTime startTime = DateTime.Now; 
        DateTime endTime = startTime.AddSeconds(_duration); 
        while (DateTime.Now < endTime) 
        { 
            Console.Write("> "); 
            string list = Console.ReadLine(); 
            lists.Add(list); 
        } 
        int _count = lists.Count; 
        Thread.Sleep(1000);
        if (_count == 1)
        {
            Console.WriteLine($"You listed {_count.ToString()} item!");
        }
        else if (_count > 1)
        {
            Console.WriteLine($"You listed {_count.ToString()} items!");
        }
    }
    public void GetRandomPrompt()
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _random = new Random();
        int index = _random.Next(_prompts.Count);
        Console.WriteLine($"---{_prompts[index]}---");
    }
}