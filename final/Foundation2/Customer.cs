using System;
using System.Collections.Concurrent;

public class Customer
{
  // Member Variables
  private string _name;

  private Address _address;

  // Constructors
  public Customer(string name, Address address)
  {
    _name = name;
    _address = address;
  }

  // Methods 
  public bool isInUSA()
  {
    return _address.IsUSA();
  }
  public string GetName()
  {
    return _name;
  }
  public string GetAddress()
  {
    return _address.FormattedAddress();
  }





}