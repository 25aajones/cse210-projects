public class ChecklistGoal : Goal
{
    private int _timesCompleted = 0;
    private int _targetCount;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int points, int targetCount, int bonus)
    {
        _name = name;
        _description = desc;
        _points = points;
        _targetCount = targetCount;
        _bonus = bonus;
    }

    public override void MarkProgress()
    {
        if (_timesCompleted < _targetCount)
            _timesCompleted++;
    }

    public override bool IsComplete() => _timesCompleted >= _targetCount;
    public override string GetStatus() =>
        $"[{(_timesCompleted >= _targetCount ? "X" : " ")}] {_name} ({_description}) -- Currently completed: {_timesCompleted}/{_targetCount}";
    public override string SaveString() =>
        $"ChecklistGoal|{_name}|{_description}|{_points}|{_targetCount}|{_bonus}|{_timesCompleted}";
    public int GetBonus() => _bonus;
}
