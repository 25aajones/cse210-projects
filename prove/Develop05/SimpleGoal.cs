public class SimpleGoal : Goal
{
    private bool _completed = false;

    public SimpleGoal(string name, string desc, int points)
    {
        _name = name;
        _description = desc;
        _points = points;
    }

    public override void MarkProgress() => _completed = true;
    public override bool IsComplete() => _completed;
    public override string GetStatus() => $"[{(_completed ? "X" : " ")}] {_name} ({_description})";
    public override string SaveString() => $"SimpleGoal|{_name}|{_description}|{_points}|{_completed}";
}
