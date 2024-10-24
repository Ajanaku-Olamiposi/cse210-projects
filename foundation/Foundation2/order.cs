using System.Numerics;

public class Order
{
    private List <Customer> _customers = new List<Customer>();

    public void AddCustomer(Customer customer1, Customer customer2)
    {
        _customers.Add(customer1);
        _customers.Add(customer2);
    }

    public string DisplayOrder()
    {
        string result = "";
        foreach(var Customer in _customers)
        {
            string ShippingLabel = Customer.ShippingLabel();
            string PackingLabel = Customer.PackingLabel();
            int TotalPrice = Customer.TotalPrice();
            result += $"PackingLabel\n{PackingLabel}ShippingLabel\n{ShippingLabel}\nTotalPrice: {TotalPrice}\n\n";
        }
        return result;
    }
}