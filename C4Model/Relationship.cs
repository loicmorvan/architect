namespace C4Model;

public class Relationship
{
    public Relationship(IModel from, IModel to)
    {
        From = from;
        To = to;
    }
    
    public IModel From { get; }

    public IModel To { get; }
}
