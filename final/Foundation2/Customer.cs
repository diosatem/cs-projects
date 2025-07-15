public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public string GetAddress()
    {
        return _address.GetFullAddress();
    }

    public bool IsFromUSA()
    {
        return _address.IsInUSA();
    }

    public string GetCustomerDetails()
    {
        return $"Customer name: {_customerName}\nCustomer address: {_address.GetFullAddress()}";
    }
}