using C4Model.Analyzers.Tarjan;
using static C4Model.Analyzers.Tarjan.Tarjan;

namespace C4Model.Analyzers;

public class CyclicRelationshipAnalyzer : IAnalyzer
{
    public IEnumerable<Issue> Analyze(Workspace workspace)
    {
        var vertices = new Dictionary<IModel, Vertex<IModel>>();
        var edges = new List<Edge<IModel>>();
        foreach (var relation in workspace.Relationships)
        {
            if (!vertices.TryGetValue(relation.From, out var fromVertex))
            {
                fromVertex = new Vertex<IModel>(relation.From);
                vertices.Add(relation.From, fromVertex);
            }
            if (!vertices.TryGetValue(relation.To, out var toVertex))
            {
                toVertex = new Vertex<IModel>(relation.To);
                vertices.Add(relation.To, toVertex);
            }

            edges.Add(new Edge<IModel>(fromVertex, toVertex));
        }

        return FindCycles<IModel>(new(vertices.Values.ToArray(), edges.ToArray()))
            .Select(c => new CycleFound(c.Vertices.Select(v => v.Value).ToArray()));
    }
}
