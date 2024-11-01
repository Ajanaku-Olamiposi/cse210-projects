using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;


public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine($"You have {DisplayPlayerInfo()} points.\n");
        Console.Write("Menu Options;\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Clear Goals\n  7. Quit\nSelect a choice from the menu: ");
    }

    public int DisplayPlayerInfo()
    {
        return _score;
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        int count = 0;
        foreach (Goal goal in _goals) 
        { 
            count++;
            string name = goal.GetName();
            Console.WriteLine($"{count}. {name}"); 
        }
    }

    public void ListGoalDetails()
    {
        int count = 0;
        foreach (Goal goal in _goals) 
        { 
            count++;
            Console.WriteLine($"{count}. {goal.GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Goal goal = null;
        Console.Write("\nThe types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\nWhich type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        
        if (choice == 1)
        {
            bool isComplete = false;
            goal = new SimpleGoal(name, description, points, isComplete);
        }
        else if (choice == 2)
        {
            goal = new EternalGoal(name, description, points);  
        }
        else if (choice == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int bonus = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int target = int.Parse(Console.ReadLine());  
            int amountCompleted = 0;
            goal = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
        }
        _goals.Add(goal);
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        if (choice > 0 && choice <= _goals.Count) 
        { 
            Goal goal = _goals[choice - 1]; 
            goal.IsComplete();
            _score += goal.GetPoints(); 
            Console.WriteLine($"Congratulations! you have earned {goal.GetPoints()} points!"); 
            Console.WriteLine($"You now have {_score} points\n"); 
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename? ");
        string file = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(DisplayPlayerInfo());
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename? ");
        string file = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            if (parts.Length == 1)
            {
                _score = int.Parse(parts[0]);
            }
            if (parts.Length == 5)
            {
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);
                SimpleGoal goal = new SimpleGoal(parts[1], parts[2], points, isComplete);
                _goals.Add(goal); 
            } 
            else if (parts[0] == "EternalGoal") 
            { 
                int points = int.Parse(parts[3]);
                EternalGoal goal = new EternalGoal(parts[1], parts[2], points); 
                _goals.Add(goal); 
            }
            else if (parts[0] == "ChecklistGoal")
            { 
                int points = int.Parse(parts[3]);
                int amountCompleted = int.Parse(parts[6]); 
                int target = int.Parse(parts[5]); 
                int bonus = int.Parse(parts[4]); 
                ChecklistGoal goal = new ChecklistGoal(parts[1], parts[2], points, bonus, target, amountCompleted); 
                _goals.Add(goal); 
            }
        }
    }

    public void ClearGoals()
    {
        Console.Write("What is the filename? ");
        string file = Console.ReadLine();
        using (FileStream fs = new FileStream(file, FileMode.Truncate)) {}
    }
}