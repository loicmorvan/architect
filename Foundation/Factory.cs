namespace Foundation;

public class Factory : IFactory
{
    public IService Create(int value)
    {
        return new Component(value);
    }

    public IOtherService Create(float value)
    {
        return new OtherComponent(value);
    }
}
