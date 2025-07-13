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

    public bool IsInUSA()
    {
        return _country.Trim().ToUpper() == "USA";
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"{_streetAddress}\n{_city}\n{_stateOrProvince}\n{_country}");
    }

}