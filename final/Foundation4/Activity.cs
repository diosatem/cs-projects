public class Activity
{
    private string _date;
    private int _activityDuration;

    public Activity(string date, int duration)
    {
        _date = date;
        _activityDuration = duration;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetActivityDuration()
    {
        return _activityDuration;
    }

    public virtual float GetDistance()
    {
        return 0;
    }

    public virtual float GetSpeed()
    {
        float speed = (GetDistance() / _activityDuration) * 60;
        // float speed = 60 / GetPace();
        return (float)Math.Round(speed, 2);
    }

    public virtual float GetPace()
    {
        // float pace = _activityDuration / GetDistance();
        float pace = 60 / GetSpeed();
        return (float)Math.Round(pace, 2);
    }

    public virtual string GetActivityType()
    {
        return "";
    }

    public void GetSummary()
    {        
        Console.WriteLine($"\u25A0 {_date} {GetActivityType()} ({_activityDuration} minutes) - Distance: {GetDistance().ToString("0.00")} km, Speed: {GetSpeed().ToString("0.00")} kph, Pace: {GetPace().ToString("0.00")} min per km");

        Console.WriteLine();
    }
}
