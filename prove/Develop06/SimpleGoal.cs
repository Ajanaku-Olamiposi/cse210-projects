using System.ComponentModel;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        _isComplete = true;
        return _isComplete;
    }
    public override string GetDetailsString() 
    { 
        if (_isComplete) 
        {
            return $"[x] {_name} ({_description})";
        }
        else
        { 
            return $"[] {_name} ({_description})"; 
        }
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{_name},{_description},{_points},{_isComplete}";
    }
}