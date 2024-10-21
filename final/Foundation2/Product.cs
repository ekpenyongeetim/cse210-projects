class Product
{
    private string _productName;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;

    // Constructor to initialize the product
    public Product(string productName, string productId, double pricePerUnit, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    // Method to calculate total price of this product
    public void GetTotalPrice()
    {
        
    }

    // Method to return the product name
    public string GetProductName()
    {
        return "";
    }

    // Method to return the product ID
    public string GetProductId()
    {
        return "";
    }
}