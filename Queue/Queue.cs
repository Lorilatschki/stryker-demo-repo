// -------------------------------------------------------
// Copyright © Siemens 2024-2025.
// -------------------------------------------------------

namespace Product;
public class Queue
{
    private string? m_Item;

    public bool IsEmpty { get; private set; } = true;

    public void Enqueue(string item)
    {
        IsEmpty = false;
        m_Item = item;
    }

    public string? Dequeue()
    {
        IsEmpty = true;
        var item = m_Item;
        return item;
    }
}
