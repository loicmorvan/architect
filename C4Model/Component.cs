namespace C4Model;

public class Component : IModel
{
    public Container? Parent { get; internal set; }

    public string Name { get; set; } = "Unnamed";

    public string Description { get; set; } = string.Empty;
}
