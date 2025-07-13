public class Product : Order
{
    private string _productName;
    private string _id;
    private float _pricePerUnit;
    private int _quantity;

    public float GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

}