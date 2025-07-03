public class EternalGoal : Goal
{
    public EternalGoal()
    {
    }

    public EternalGoal(string name, string desc, int points, int times) : base(name, desc, points, times)
    {
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        return 0;
    }
}