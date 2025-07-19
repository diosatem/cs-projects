public class Running : Activity
{
    private float _distance;

    public Running(string date, int duration, float distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return (float)Math.Round(_distance, 2);
    }

    public override string GetActivityType()
    {
        return "Running";
    }
}
