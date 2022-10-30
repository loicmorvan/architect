using System.Collections.Immutable;

namespace C4Model.Analyzers.Tarjan;

public record Cycle<T>(ImmutableArray<Vertex<T>> Vertices);
