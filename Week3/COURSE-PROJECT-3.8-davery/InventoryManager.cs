//Inventory Manager Class
public class InventoryManager
{
    private List<ProductBase> inventoryItems = new List<ProductBase>();

    public void AddProduct(ProductBase product)
    {
        inventoryItems.Add(product);
    }

    public void RemoveProduct(string productName)
    {
        inventoryItems.RemoveAll(p => p.Name == productName);
    }

    public void DisplayInventory()
    {
        foreach (var item in inventoryItems)
        {
            item.DisplayProductDetails();
        }
    }
}