namespace Foundation.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var factory = FactoryCreator.Create<IFactory>();

        Assert.NotNull(factory.CreateService(54));
    }
}
