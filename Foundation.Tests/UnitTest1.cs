namespace Foundation.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var factory = FactoryCreator.Create();

        Assert.NotNull(factory.Create(54));
        Assert.NotNull(factory.Create(3f));
    }
}
