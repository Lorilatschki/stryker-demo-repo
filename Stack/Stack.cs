// -------------------------------------------------------
// Copyright © Siemens 2024-2025.
// -------------------------------------------------------

namespace Product;
public class Stack
{
    private string? m_Item;

    public bool IsEmpty { get; private set; } = true;

    public void Push(string item)
    {
        IsEmpty = false;
        m_Item = item;
    }

    public string? Pop()
    {
        IsEmpty = true;
        var item = m_Item;
        return item;
    }
}
