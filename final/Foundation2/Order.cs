class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Constructor to initialize the order with customer and product list
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate the total cost of the order (including shipping)
    public double CalculateTotalCost()
    {
        double totalCost = 0;

        // Calculate total product cost
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalPrice();
        }

        // Add shipping cost based on the customer's location
        totalCost += _customer.LivesInUSA() ? 5 : 35;

        return totalCost;
    }

    // Method to return the packing label
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetProductName()} (ID: {product.GetProductId()})\n";
        }
        return packingLabel;
    }

    // Method to return the shipping label
    public string GetShippingLabel()
    {
        string shippingLabel = $"Shipping Label:\n{_customer.GetCustomerName()}\n{_customer.GetCustomerAddress().GetFullAddress()}";
        return shippingLabel;
    }
}