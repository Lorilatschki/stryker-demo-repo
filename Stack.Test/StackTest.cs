// -------------------------------------------------------
// Copyright © Siemens 2024-2025.
// -------------------------------------------------------

namespace Test;

public class StackTest
{
    [Fact]
    public void NewStack_IsEmpty()
    {
        var sut = new Product.Stack();
        Assert.True(sut.IsEmpty);
    }

    [Fact]
    public void NewStack_AddItem_NotEmpty()
    {
        var sut = new Product.Stack();
        sut.Push("Hello");
        Assert.False(sut.IsEmpty);
    }
}