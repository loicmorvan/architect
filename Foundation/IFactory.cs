namespace Foundation;

public interface IFactory
{
    IService CreateService(int value, float otherValue);
    IOtherService CreateOtherService(string test);
}

public interface IOtherService
{

}