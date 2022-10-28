namespace C4Model;

public class Workspace
{
    private readonly List<Relationship> relationships = new();
    private readonly List<SoftwareSystem> softwareSystems = new();

    public IEnumerable<Relationship> Relationships => relationships.AsEnumerable();

    public Relationship AddRelationship(IModel from, IModel to)
    {
        if (!Contains(from) || !Contains(to))
            throw new ArgumentException("from or to is not in this workspace");

        var relationship = new Relationship(from, to);

        relationships.Add(relationship);

        return relationship;
    }

    public IEnumerable<SoftwareSystem> SoftwareSystems => softwareSystems.AsEnumerable();

    public bool Contains(IModel model)
    {
        return SoftwareSystems.Contains(model)
            || SoftwareSystems.Any(s => s.Contains(model));
    }
}
