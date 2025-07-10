public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public abstract void MarkProgress();
    public abstract bool IsComplete();
    public abstract string GetStatus();
    public abstract string SaveString();

    public int GetPoints() => _points;
    public string GetName() => _name;
}
