public class EternalGoal : Goal
{
    private int _count = 0;

    public EternalGoal(string name, string desc, int points)
    {
        _name = name;
        _description = desc;
        _points = points;
    }

    public override void MarkProgress() => _count++;
    public override bool IsComplete() => false;
    public override string GetStatus() => $"[ ] {_name} ({_description})";
    public override string SaveString() => $"EternalGoal|{_name}|{_description}|{_points}|{_count}";
}
