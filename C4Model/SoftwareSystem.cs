namespace C4Model;

public class SoftwareSystem : IModel
{
    private readonly List<Container> containers = new();

    public IEnumerable<Container> Containers => containers.AsEnumerable();

    public Container CreateContainer()
    {
        var container = new Container();
        containers.Add(container);

        return container;
    }

    public bool Contains(IModel model)
    {
        return Containers.Contains(model)
            || Containers.Any(container => container.Contains(model));
    }

    public string Name { get; set; } = "Unnamed";

    public string Description { get; set; } = "No description so far.";
}
