public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateOrProvince = stateProvince;
        _country = country;
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}, {_city}, {_stateOrProvince}, {_country}";
    }
}
