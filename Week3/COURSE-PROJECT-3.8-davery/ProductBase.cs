//Abstract Class
public abstract class ProductBase : IProductOperations
{
    private static int nextProductId = 1;

    public int ProductId { get; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public float Price { get; set; }

    public ProductBase(string name, int quantity, float price)
    {
        ProductId = nextProductId++;
        Name = name;
        Quantity = quantity;
        Price = price;
    }

    public void UpdateQuantity(int newQuantity)
    {
        Quantity = newQuantity;
    }

    public void UpdatePrice(float newPrice)
    {
        Price = newPrice;
    }

    public abstract void DisplayProductDetails();
}