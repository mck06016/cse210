using System;

public class Product
{
  // Member variables
  private string _name;
  private string _productID;
  private decimal _price;
  private int _quantity;
  // Methods (Getters and Setters)
  // Eliminated Unused Getters and Setters
  public decimal GetPrice()
  {
    return _price;
  }
  public int GetQuantity()
  {
    return _quantity;
  }
  // Constructors
  public Product(string name, string productID, decimal price)
  {
    _name = name;
    _productID = productID;
    _price = price;
  }
  public Product(string name, string productID, decimal price, int quantity)
  {
    _name = name;
    _productID = productID;
    _price = price;
    _quantity = quantity;
  }
  // Methods
  public static decimal Price(decimal price, int quantity)
  {
    return price * quantity;
  }
  public void DisplayProduct()
  {
    Console.Write($"{_productID} - {_name}");
  }
  public void DisplayProductInvoice()
  {
    decimal cost = Product.Price(_price, _quantity);
    Console.Write($"{_productID} - {_name}: {_quantity}@  ${_price} = ${cost}");
  }
}