public class Order
{
    private Product _product;
    private List<Product> _products;
    private Customer _customer;
    private float _shippingCost;
    private string _packingLabel;
    private string _shippingLabel;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public float ShippingCost()
    {
        return _customer.    }
        
    public float GetTotalPrice()
    {
        return _product.GetTotalCost() + _shippingCost;
    }
    // + GetPackingLabel() : string
    // + GetShippingLabel() : string

}