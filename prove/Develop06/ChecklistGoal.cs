public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int bonus, int target,int amountCompleted) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        IsComplete();
    }

    public override bool IsComplete()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            _points += _bonus;
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        if (_amountCompleted >= _target)
        {
            return $"[x] {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[] {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_name},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}