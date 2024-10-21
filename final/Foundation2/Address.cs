class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructor to initialize the address
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Method to check if the address is in the USA
    public void IsInUSA()
    {
       
    }

    // Method to return the full address as a string
    public string GetFullAddress()
    {
        return "";
    }
}