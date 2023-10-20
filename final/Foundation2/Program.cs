using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("125 First Ave", "Ammon", "ID", "84506", "USA");
        Customer customer1 = new Customer("Julia McKenzie", address1);
        Order order1 = new Order(customer1);
        Product p1 = new Product("Apples", "FRUIT89", 1.23m, 10);
        Product p2 = new Product("Oranges", "FRUIT54", 0.66m, 15);
        Product p3 = new Product("Milk", "DAIRY25", 3.42m, 2);
        Product p4 = new Product("Chedar Cheese", "DAIRY76", 9.90m, 1);

        order1.AddProduct(p1);
        order1.AddProduct(p2);
        order1.AddProduct(p3);
        order1.AddProduct(p4);

        order1.PackingLabel();
        Console.WriteLine();
        order1.ShippingLabel();
        Console.WriteLine();
        order1.Cost();

        Address address2 = new Address("999 Lakeview Ave.", "Cultus Lake", "BC", "V2R4Y5", "Canada");
        Customer customer2 = new Customer("Gwen McKenzie", address2);
        Order order2 = new Order(customer2);
        Product p5 = new Product("Diet Pepsi", "SODA6", 3.54m, 4);
        Product p6 = new Product("Dairy Milk", "CANDY23", 2.19m, 2);

        order2.AddProduct(p5);
        order2.AddProduct(p6);

        order2.PackingLabel();
        Console.WriteLine();
        order2.ShippingLabel();
        Console.WriteLine();
        order2.Cost();

    }
}