namespace Foundation;

public class Component: IService
{
    private readonly int value;

    public Component(IServiceProvider serviceProvider, int value, float otherValue)
    {
        serviceProvider.ToString();
        this.value = value;
    }
}
