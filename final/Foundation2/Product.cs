public class Product
{
    private string _productName;
    private string _id;
    private float _pricePerUnit;
    private int _quantity;

    public Product(string name, string id, float pricePerUnit, int quantity)
    {
        _productName = name;
        _id = id;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductId()
    {
        return _id;
    }

    public float GetPricePerUnit()
    {
        return _pricePerUnit;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public float GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"Product Name: {_productName}");
        Console.WriteLine($"Quantity: {_quantity}");
        Console.WriteLine($"Price Per Unit: ${_pricePerUnit}");
    }
}