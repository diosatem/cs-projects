public class Reception : Event
{
    private string _email;

    public Reception(string title, string desc, string date, string time, Address address, string email) : base(title, desc, date, time, address)
    {
        _email = email;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nRSVP to {_email}";
    }

    public string GetEventType()
    {
        return "Reception";
    }
}
