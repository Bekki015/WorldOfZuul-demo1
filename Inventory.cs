public class Inventory
{
public List<Item> inventory = new List<Item>();
public void AddItem(Item Item)
{
    inventory.Add(Item);
    Console.WriteLine($"{Item} has been added to your inventory!");
}
public void RemoveItem(Item Item)
{
    inventory.Remove(Item);
    Console.WriteLine($"{Item} has been removed from your inventory!");
}
public void ShowItems()
{
    Console.WriteLine($"You currently have {inventory.Count()} items in your inventory!");
    foreach(Item item in inventory)
    {
        Console.WriteLine($"{item.itemName}, {item.itemDesc}");
    }
}
}
