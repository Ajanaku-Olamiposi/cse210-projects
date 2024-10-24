public class Product
{
    private string _name;
    private int _productId;
    private int _price;
    private int _quantity;

    public Product(string name, int productId, int price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public string PackingLabel()
    {
        return $"Product name: {_name}, Product_Id: {_productId}\n";
    }
    public int TotalCost()
    {
        return _price * _quantity;
    }
}