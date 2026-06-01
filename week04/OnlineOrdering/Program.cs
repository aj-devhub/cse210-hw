using System;

class Program
{
    static void Main(string[] args)
    {
        // ===== ORDER 1 (USA CUSTOMER) =====
        Address address1 = new Address("12 Main Street", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", 101, 500, 1));
        order1.AddProduct(new Product("Mouse", 102, 20, 2));

        Console.WriteLine("ORDER 1");
        Console.WriteLine("PACKING LABEL");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"TOTAL PRICE: ${order1.GetTotalPrice()}");
        Console.WriteLine("-----------------------------------");

        // ===== ORDER 2 (NON-USA CUSTOMER) =====
        Address address2 = new Address("45 Ikeja Road", "Lagos", "Lagos", "Nigeria");
        Customer customer2 = new Customer("Amina Yusuf", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", 201, 300, 1));
        order2.AddProduct(new Product("Headphones", 202, 50, 3));

        Console.WriteLine("ORDER 2");
        Console.WriteLine("PACKING LABEL");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"TOTAL PRICE: ${order2.GetTotalPrice()}");
        Console.WriteLine("-----------------------------------");
    }
}