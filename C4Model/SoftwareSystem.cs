namespace C4Model;

public class SoftwareSystem: IModel
{
    public List<Container> Containers { get; } = new();

    public bool Contains(IModel model)
    {
        return Containers.Contains(model)
            || Containers.Any(container => container.Contains(model));
    }
}
