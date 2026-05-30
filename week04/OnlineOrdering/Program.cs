using System;

class Program
{
    static void Main(string[] args)
    {
         // Order 1 (USA customer)
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P100", 800, 1));
        order1.AddProduct(new Product("Mouse", "P200", 20, 2));

        // Order 2 (International customer)
        Address address2 = new Address("45 Kampala Rd", "Kampala", "Central", "Uganda");
        Customer customer2 = new Customer("Innocent Murungi", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P300", 500, 1));
        order2.AddProduct(new Product("Headphones", "P400", 50, 3));

        // Display results
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");

        Console.WriteLine("\n----------------------\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}