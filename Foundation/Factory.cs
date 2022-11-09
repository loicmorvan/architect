namespace Foundation;

public class Factory : IFactory
{
    public IService CreateService(int value)
    {
        return new Component(value);
    }

    public IOtherService CreateOtherService(float value)
    {
        return new OtherComponent(value);
    }
}
