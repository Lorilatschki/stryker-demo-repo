namespace Product;

/// <summary>
/// Represents a simple queue data structure.
/// </summary>
#pragma warning disable CA1711 // Identifiers should not have incorrect suffix
public class Queue
#pragma warning restore CA1711 // Identifiers should not have incorrect suffix
{
    private string? m_Item;
    private bool m_IsEmpty = true;

    /// <summary>
    /// Gets a value indicating whether the queue is empty.
    /// </summary>
    public bool IsEmpty => m_IsEmpty;

    /// <summary>
    /// Adds an item to the queue.
    /// </summary>
    /// <param name="item">The item to add to the queue.</param>
    public void Enqueue(string item)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(item);
        m_IsEmpty = false;
        m_Item = item;
    }

    /// <summary>
    /// Removes and returns the item from the queue.
    /// </summary>
    /// <returns>The item that was removed from the queue, or null if the queue is empty.</returns>
    public string? Dequeue()
    {
        m_IsEmpty = true;
        var item = m_Item;
        return item;
    }
}
