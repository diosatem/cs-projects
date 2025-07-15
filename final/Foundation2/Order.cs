public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public float GetTotalPrice()
    {
        float total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }
        return total + ShippingCost();
    }

    private float ShippingCost()
    {
        return _customer.IsFromUSA() ? 5 : 35;
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine("PACKING LABEL");
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product Name: {product.GetProductName()}");
            Console.WriteLine($"Product ID: {product.GetProductId()}");
            Console.WriteLine("---");
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(_customer.GetCustomerDetails());
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void DisplayOrder()
    {
        DisplayShippingLabel();
        Console.WriteLine();

        Console.WriteLine("ORDER SUMMARY");
        foreach (Product product in _products)
        {
            product.DisplayProduct();
            Console.WriteLine("---");
        }

        Console.WriteLine($"Total Price: ${GetTotalPrice()}");
        Console.WriteLine();

        DisplayPackingLabel();
        Console.WriteLine();
    }
}