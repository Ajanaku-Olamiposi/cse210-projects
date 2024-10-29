public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    Random _random;
    public ReflectingActivity(string name, string description): base(name, description)
    {}
    public string GetRandomPrompt()
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",        
        };
        _random = new Random();
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
    public string GetRandomQuestion()
    {
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        _random = new Random();
        if (_questions.Count == 0) 
        { 
            return "No more questions available."; 
        } 
        int index = _random.Next(_questions.Count); 
        string selectedQuestion = _questions[index]; 
        _questions.RemoveAt(index); 
        return selectedQuestion;
    }
    public void DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner2(1000);
            Console.WriteLine();
        }
    }
}