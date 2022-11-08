namespace Foundation;

public interface IFactory
{
    IService Create(int value);
    IOtherService Create(float value);
}
