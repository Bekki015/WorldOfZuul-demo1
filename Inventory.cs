public class InventoryClass
{
    // ISSUE 1: Public setter allows external code to replace the entire inventory list
    // This breaks encapsulation and could lead to bugs if someone sets it to null
    // Consider making this private set or using a readonly collection
    public List<string> inventory {get; private set;}

    // ISSUE 2: No constructor
    // The inventory list is not initialized, which will cause a NullReferenceException
    // when trying to add the first item
    public InventoryClass()
    {
        inventory = new List<string>();
    }

    // ISSUE 3: No return value to indicate success/failure
    // Callers can't know if the operation succeeded
    // Also no validation for null/empty items
    public void AddItem(string item)
    {
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item), "Item cannot be null");
        }
        if (string.IsNullOrEmpty(item))
        {
            throw new ArgumentException("Item cannot be empty", nameof(item));
        }
        inventory.Add(item);
    }

    // ISSUE 4: Similar to AddItem - no return value or error handling
    // Remove() returns bool in List<T>, but we're not using it
    // Also no check if item exists before trying to remove
    public void RemoveItem(string item)
    {
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item), "Item cannot be null");
        }
        if (string.IsNullOrEmpty(item))
        {
            throw new ArgumentException("Item cannot be empty", nameof(item));
        }
        inventory.Remove(item);
    }
}