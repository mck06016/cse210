using System;

public class Address
{
  // Member Variables
  private string _street;
  private string _city;
  private string _stateProvince;
  private string _zipPostalCode;
  private string _country;
  // Eliminated Unused Getters and Setters
  // Constructors
  public Address(string street, string city, string stateProvince, string zipPostalCode, string country)
  {
    _street = street;
    _city = city;
    _stateProvince = stateProvince;
    _zipPostalCode = zipPostalCode;
    _country = country;
  }

  // Methods
  public string FormattedAddress()
  {
    return $"{_street}\n{_city}, {_stateProvince}\n{_zipPostalCode}\n{_country}";
  }

}