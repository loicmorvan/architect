namespace Foundation.Tests.TestTypes;

public interface IFactory
{
    IService CreateService(int value);
}