namespace Foundation;

public interface IFactory
{
    IService CreateService(int value);
    IOtherService CreateOtherService(float value);
}
