public class Event
{
    private string _eventTitle;
    private string _description;
    private string _dateText;
    private string _timeText;
    private Address _address;
    private string _eventType;

    public Event(string eventTitle, string description, string dateText, string timeText, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _dateText = dateText;
        _timeText = timeText;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Event title: {_eventTitle}\nDescription: {_description}\nDate: {_dateText}\nTime: {_timeText}\nAddress: {_address.GetFullAddress()}";
    }

    public string GetShortDescription(string type)
    {
        _eventType = type;

        return $"Event type: {_eventType}\nEvent title: {_eventTitle}\nDate: {_dateText}";
    }
}
