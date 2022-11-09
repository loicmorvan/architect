namespace Foundation.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var factory = FactoryCreator.Create();

        Assert.NotNull(factory.CreateService(54));
        Assert.NotNull(factory.CreateOtherService(3f));
    }
}
