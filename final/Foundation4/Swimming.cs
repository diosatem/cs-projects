public class Swimming : Activity
{
    private int _lapCount;

    public Swimming(string date, int duration, int lapCount) : base(date, duration)
    {
        _lapCount = lapCount;
    }

    public override string GetActivityType()
    {
        return "Swimming";
    }

    public override float GetDistance()
    {
        float distance = (_lapCount * 50f) / 1000f;
        return (float)Math.Round(distance, 2);
    }

    public override float GetSpeed()
    {
        float speed = (GetDistance() / GetActivityDuration()) * 60;
        return (float)Math.Round(speed, 2);
    }

    public override float GetPace()
    {
        float pace = GetActivityDuration() / GetDistance();
        return (float)Math.Round(pace, 2);
    }
}