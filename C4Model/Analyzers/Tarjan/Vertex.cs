namespace C4Model.Analyzers.Tarjan;

public class Vertex<T>
{
    public Vertex(T value)
    {
        Value = value;
    }

    public T Value { get; }
    public int Index { get; set; } = -1;
    public int LowLink { get; set; } = -1;
    public bool OnStack { get; set; }
}
