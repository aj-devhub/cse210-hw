public class ChecklistGoal : Goal
{
    private int _target;
    private int _count;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int points, int target, int bonus, int count = 0)
        : base(name, desc, points)
    {
        _target = target;
        _bonus = bonus;
        _count = count;
    }

    public override int RecordEvent()
    {
        _count++;
        if (_count == _target)
        {
            return _points + _bonus;
        }
        return _points;
    }

    public override bool IsComplete()
    {
        return _count >= _target;
    }

    public override string GetStatus()
    {
        return $"[{_count}/{_target}]";
    }

    public override string GetDetailsString()
    {
        return $"{GetStatus()} {_name} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_target}|{_bonus}|{_count}";
    }
}