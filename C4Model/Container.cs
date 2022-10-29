namespace C4Model;

public class Container : IModel
{
    private List<Component> components = new();

    public IEnumerable<Component> Components => components.AsEnumerable();

    public Component CreateComponent()
    {
        var component = new Component();
        components.Add(component);

        return component;
    }

    public bool Contains(IModel model)
    {
        return Components.Contains(model);
    }

    public string Name { get; set; } = "Unnamed";

    public string Description { get; set; } = string.Empty;
}
