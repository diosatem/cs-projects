public class OutdoorGathering : Event
{
    private string _weatherStatement;

    public OutdoorGathering(string title, string desc, string date, string time, Address address, string weather) : base(title, desc, date, time, address)
    {
        _weatherStatement = weather;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nWeather Forecast: {_weatherStatement}";
    }

    public string GetEventType()
    {
        return "Outdoor Gathering";
    }
}

