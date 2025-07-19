public class Cycling : Activity
{
    private float _speed;

    public Cycling(string date, int duration, float speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override string GetActivityType()
    {
        return "Cycling";
    }

    public override float GetDistance()
    {
        float duration = GetActivityDuration() / 60;
        float distance = _speed * duration;
        return (float)Math.Round(distance, 2);
    }

    public override float GetPace()
    {
        float pace = GetActivityDuration() / GetDistance();
        return (float)Math.Round(pace, 2);
    }
}
