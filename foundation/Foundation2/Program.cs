using System;

class Program
{
    static void Main(string[] args)
    {
        string streetAddress1 = "19 Ologuneru";
        string city1 = "Ibadan";
        string state1 = "Oyo";
        string country1 = "Nigeria";
        Address address1 = new Address(streetAddress1, city1, state1, country1);

        string name1 = "Book";
        int productId1 = 111111;
        int price1 = 50;
        int quantity1 = 4;
        Product product1 = new Product(name1, productId1, price1, quantity1);
        string name2 = "Pen";
        int productId2 = 222222;
        int price2 = 30;
        int quantity2 = 4;
        Product product2 = new Product(name2, productId2, price2, quantity2);

        string nameOfPerson1 = "Joy";
        Customer customer1 = new Customer(nameOfPerson1, address1, product1, product2);

        string streetAddress2 = "21 Under-G Road";
        string city2 = "Hawali";
        string state2 = "Idaho";
        string country2 = "USA";
        Address address2 = new Address(streetAddress2, city2, state2, country2);

        string name3 = "Singlet";
        int productId3 = 333333;
        int price3 = 70;
        int quantity3 = 10;
        Product product3 = new Product(name3, productId3, price3, quantity3);
        string name4 = "Boxer";
        int productId4 = 444444;
        int price4 = 40;
        int quantity4 = 5;
        Product product4 = new Product(name4, productId4, price4, quantity4);

        string nameOfPerson2 = "James";
        Customer customer2 = new Customer(nameOfPerson2,address2, product3, product4);

        Order order = new Order();
        order.AddCustomer(customer1, customer2);
        Console.WriteLine(order.DisplayOrder());
    }
}