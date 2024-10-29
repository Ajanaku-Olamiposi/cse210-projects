using System.Security.Principal;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n\n{_description}");
        Console.Write($"How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.Write("Get ready... in ");
        Console.WriteLine(ShowCountDown(5));
        ShowSpinner(1000);
        Console.WriteLine("Start");
    }
    public void DisplayEndingMessage()
    {
        Thread.Sleep(1000);
        Console.WriteLine("Well done!!!");
        ShowSpinner(1000);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");
        ShowSpinner(1000);
        Console.Clear();
    }
    public void ShowSpinner(int seconds)
    {
        List<string> signs = new List<string>();
        signs.Add(" ");
        signs.Add("  ");
        signs.Add("   ");
        signs.Add("    ");
        signs.Add("     ");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);
        while (DateTime.Now < endTime)
        {
            foreach (string sign in signs)
            {
                Console.Write(sign);
                Thread.Sleep(seconds);
                Console.Write("\b\b\b\b\b");
            }
        }
    }
    public void ShowSpinner2(int seconds)
    {
        List<string> signs = new List<string>();
        signs.Add("+");
        signs.Add("-");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);
        while (DateTime.Now < endTime)
        {
            foreach (string sign in signs)
            {
                Console.Write(sign);
                Thread.Sleep(seconds);
                Console.Write("\b \b");
            }
        }
    }
    public string ShowCountDown(int seconds)
    {  
        string countDown = "";
        for(int i= seconds; i>0; i--) 
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        } 
        return countDown;
    }
    
}