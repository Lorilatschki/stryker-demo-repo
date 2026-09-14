namespace Product;

/// <summary>
/// Represents a simple stack data structure for string items.
/// </summary>
#pragma warning disable CA1711 // Identifiers should not have incorrect suffix
public class Stack
#pragma warning restore CA1711 // Identifiers should not have incorrect suffix
{
    private string? m_Item;
    private bool m_IsEmpty = true;

    /// <summary>
    /// Gets a value indicating whether the stack is empty.
    /// </summary>
    public bool IsEmpty => m_IsEmpty;

    /// <summary>
    /// Pushes an item onto the stack.
    /// </summary>
    /// <param name="item">The item to push onto the stack.</param>
    public void Push(string item)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(item);
        m_IsEmpty = false;
        m_Item = item;
    }

    /// <summary>
    /// Pops an item from the stack.
    /// </summary>
    /// <returns>The item that was popped from the stack, or null if the stack is empty.</returns>
    public string? Pop()
    {
        m_IsEmpty = true;
        var item = m_Item;
        return item;
    }
}
