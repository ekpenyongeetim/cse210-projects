class Customer
{
    private string _customerName;
    private Address _address;

    // Constructor to initialize the customer
    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    // Method to check if the customer lives in the USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // Method to return the customer name
    public string GetCustomerName()
    {
        return _customerName;
    }

    // Method to return the customer address
    public Address GetCustomerAddress()
    {
        return _address;
    }
}