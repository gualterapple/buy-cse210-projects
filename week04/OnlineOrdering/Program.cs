using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer cust1 = new Customer("Alice Johnson", addr1);

        Address addr2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Carlos Silva", addr2);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "P001", 1200.00, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25.50, 2));

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Monitor", "P003", 300.00, 1));
        order2.AddProduct(new Product("Keyboard", "P004", 75.00, 1));
        order2.AddProduct(new Product("USB Cable", "P005", 10.00, 3));

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalCost():0.00}");
            Console.WriteLine(new string('-', 40));
        }
    }
}