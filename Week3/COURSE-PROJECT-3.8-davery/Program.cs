/*******************************************************************
* Name: Devin Avery
* Date: 10/9/2024
* Assignment: SDC320 Week 3 Project Implementation
*/

class Program
{
    static void Main()
    {
        InventoryManager inventory = new InventoryManager();

        // Adding products to the inventory
        Product product1 = new Product("Product A", 10, 20.5f);
        Product product2 = new Product("Product B", 15, 30.75f);

        inventory.AddProduct(product1);
        inventory.AddProduct(product2);

        // Display all products in the inventory
        Console.WriteLine("Inventory:");
        inventory.DisplayInventory();

        // Updating product details and displaying again
        product1.UpdateQuantity(5);
        product2.UpdatePrice(40.0f);

        Console.WriteLine("\nUpdated Inventory:");
        inventory.DisplayInventory();
    }
}