namespace Foundation;

public class Component: IService
{
    public Component(int value, float otherValue)
    {
        System.Console.WriteLine($"{value}, {otherValue}");
    }
}
