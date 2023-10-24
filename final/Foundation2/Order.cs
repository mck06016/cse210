using System;

public class Order
{
  // Member variables
  private List<Product> _products;
  private Customer _customer;
  // Eliminated Unused Getters and Setterss
  // Constructors
  public Order(Customer customer)
  {
    _customer = customer;
    _products = new List<Product>();
  }
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
  public void Cost()
  {
    decimal total = 0;
    foreach (Product product in _products)
    {
      decimal price = Product.Price(product.GetPrice(), product.GetQuantity());
      total = total + price;
    }
    //Shipping Cost
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