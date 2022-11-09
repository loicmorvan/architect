namespace Foundation;

public interface IFactory
{
    IService CreateService(int value, float otherValue);
}
