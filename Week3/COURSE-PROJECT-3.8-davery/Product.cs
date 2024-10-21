//Product class
public class Product : ProductBase
{
    public Product(string name, int quantity, float price) : base(name, quantity, price)
    {
    }

    public override void DisplayProductDetails()
    {
        Console.WriteLine($"Product ID: {ProductId}, Name: {Name}, Quantity: {Quantity}, Price: {Price}");
    }
}