public class Customer : Order
{
    private string _customerName;
    private Address _address;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }

    public Customer()
    {
        
    }

    public bool IsFromUSA()
    {
        return _address.IsInUSA();
    }

    // public void DisplayCustomer()
    // {
    //     Console.WriteLine($"{_customerName}\n{_addresses}");
    // }
}