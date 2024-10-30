public class InventoryClass
{
public List<string> inventory {get; set;}

public void AddItem(string item)
{
    inventory.Add(item);
}
public void RemoveItem(string item)
{
    inventory.Remove(item);
}
}
