using System.Collections.Concurrent;

public class Customer
{
    private string _name;
    private Address _address;
    private List <Product> _products = new List<Product>();

    public Customer(string name, Address address, Product product1, Product product2)
    {
        _address = address;
        _name = name;
        _products.Add(product1);
        _products.Add(product2);
    }

    public string PackingLabel()
    {
        string products = "";
        foreach (var product in _products)
        {
            products += product.PackingLabel();
        }
        return products;
    }

    public bool Country()
    {
        if (_address.Country())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public int TotalPrice()
    {
        int TotalCost = 0;
        foreach (var product in _products)
        {
            TotalCost += product.TotalCost();
        }
        int TotalPrice;
        if(Country())
        {
            int shippingCost = 35;
            TotalPrice = shippingCost + TotalCost;
        }
        else
        {
            int shippingCost = 5;
            TotalPrice = shippingCost + TotalCost;
        }
        return TotalPrice;
    }
    public string ShippingLabel()
    {
        return $"Name: {_name}\n{_address.DisplayAddress()}";
    }
}