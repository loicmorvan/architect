namespace C4Model;

public class Container: IModel
{
    public List<Component> Components { get; } = new();
    public bool Contains(IModel model)
    {
        return Components.Contains(model);
    }
}
