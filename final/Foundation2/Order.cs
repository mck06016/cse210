using System;

public class Order
{
  // Member variables
  List<Product> _products;
  private Customer _customer;

  // Constructors
  public Order(Customer customer)
  {
    _customer = customer;
    _products = new List<Product>();
  }

  // Methods (Getters and Setters)


  // Methods
  public void AddProduct(Product product)
  {
    _products.Add(product);
  }
  public void PackingLabel()
  {
    Console.WriteLine($"Customer: {_customer.GetName()}");
    Console.WriteLine($"Packing Label: ");
    foreach (Product product in _products)
    {
      product.DisplayProductInvoice();
      Console.WriteLine();
    }
  }
  public void ShippingLabel()
  {
    Console.WriteLine($"Shipping Label: ");
    Console.WriteLine($"Customer: {_customer.GetName()}");
    Console.WriteLine(_customer.GetAddress());

  }

  public void Cost()  // change to float once code is complete
  {
    decimal total = 0;
    foreach (Product product in _products)
    {
      decimal price = product.Price(product.GetPrice(), product.GetQuantity());
      total = total + price;
    }

    //Address Shipping
    if (_customer.isInUSA())
    {
      total += 5;
      Console.WriteLine("Shipping will be $5.");
    }
    else
    {
      total += 35;
      Console.WriteLine("Shipping will be $35.");
    }

    Console.WriteLine($"Total Cost: ${total}.");
  }
}