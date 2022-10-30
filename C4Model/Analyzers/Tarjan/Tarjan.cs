using System.Collections.Immutable;

namespace C4Model.Analyzers.Tarjan;

public static class Tarjan
{
    public static IEnumerable<Cycle<T>> FindCycles<T>(Graph<T> graph)
    {
        // Algorithm from: https://en.wikipedia.org/wiki/Tarjan%27s_strongly_connected_components_algorithm#The_algorithm_in_pseudocode

        var index = 0;
        var stack = new Stack<Vertex<T>>();
        foreach (var vertex in graph.Vertices)
        {
            if (vertex.Index == -1)
            {
                foreach (var cycle in StrongConnect(vertex))
                {
                    yield return cycle;
                }
            }
        }

        IEnumerable<Cycle<T>> StrongConnect(Vertex<T> vertex)
        {
            vertex.Index = index;
            vertex.LowLink = index;

            index += 1;

            stack!.Push(vertex);
            vertex.OnStack = true;

            foreach (var successor in graph.Edges.Where(e => e.From == vertex).Select(e => e.To))
            {
                if (successor.Index == -1)
                {
                    foreach (var cycle in StrongConnect(successor))
                    {
                        yield return cycle;
                    }
                    vertex.LowLink = Math.Min(vertex.LowLink, successor.LowLink);
                }
                else if (successor.OnStack)
                {
                    vertex.LowLink = Math.Min(vertex.LowLink, successor.Index);
                }
            }

            if (vertex.LowLink == vertex.Index)
            {
                var cycle = new List<Vertex<T>>();
                Vertex<T> vertexInCycle;
                do
                {
                    vertexInCycle = stack.Pop();
                    vertexInCycle.OnStack = false;
                    cycle.Add(vertexInCycle);
                } while (vertexInCycle != vertex);
                yield return new(cycle.ToImmutableArray());
            }
        }
    }
}
