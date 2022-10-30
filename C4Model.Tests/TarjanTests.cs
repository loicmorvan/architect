using System.Collections.Immutable;
using C4Model.Analyzers.Tarjan;
using static C4Model.Analyzers.Tarjan.Tarjan;

public class TarjanTests
{
    [Fact]
    public void FindCycleTests()
    {
        var vertex0 = new Vertex<int>(0);
        var vertex1 = new Vertex<int>(1);
        var vertex2 = new Vertex<int>(2);
        var graph = new Graph<int>(
            new[] { vertex0, vertex1, vertex2 },
            new[] {
                new Edge<int>(vertex0, vertex1),
                new Edge<int>(vertex1, vertex2),
                new Edge<int>(vertex2, vertex0),
             }
        );

        var result = FindCycles<int>(graph).ToArray();

        var cycle = Assert.Single(result);
        Assert.Equal(new[] { vertex2, vertex1, vertex0 }, cycle.Vertices);
    }
}
