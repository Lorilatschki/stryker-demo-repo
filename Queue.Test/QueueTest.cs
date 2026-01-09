// -------------------------------------------------------
// Copyright © Siemens 2024-2025.
// -------------------------------------------------------

namespace Test;

public class QueueTest
{
    [Fact]
    public void NewQueue_IsEmpty()
    {
        var sut = new Product.Queue();
        Assert.True(sut.IsEmpty);
    }

    [Fact]
    public void NewQueue_AddItem_NotEmpty()
    {
        var sut = new Product.Queue();
        sut.Enqueue("Hello");
        Assert.False(sut.IsEmpty);
    }
}