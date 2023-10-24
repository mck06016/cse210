using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new("125 First Ave", "Ammon", "ID", "84506", "USA");
        Customer customer1 = new("Julia McKenzie", address1);
        Order order1 = new(customer1);
        Product p1 = new("Apples", "FRUIT89", 1.23m, 10);
        Product p2 = new("Oranges", "FRUIT54", 0.66m, 15);
        Product p3 = new("Milk", "DAIRY25", 3.42m, 2);
        Product p4 = new("Chedar Cheese", "DAIRY76", 9.90m, 1);

        order1.AddProduct(p1);
        order1.AddProduct(p2);
        order1.AddProduct(p3);
        order1.AddProduct(p4);

        Address address2 = new("999 Lakeview Ave.", "Cultus Lake", "BC", "V2R4Y5", "Canada");
        Customer customer2 = new("Gwen McKenzie", address2);
        Order order2 = new(customer2);
        Product p5 = new("Diet Pepsi", "SODA6", 3.54m, 4);
        Product p6 = new("Dairy Milk", "CANDY23", 2.19m, 2);

        order2.AddProduct(p5);
        order2.AddProduct(p6);

        Console.Clear();
        Console.WriteLine("Order: ");
        order1.PackingLabel();
        Console.WriteLine();
        order1.ShippingLabel();
        Console.WriteLine();
        order1.Cost();

        Console.WriteLine();
        Console.WriteLine("Order: ");
        order2.PackingLabel();
        Console.WriteLine();
        order2.ShippingLabel();
        Console.WriteLine();
        order2.Cost();

    }
}