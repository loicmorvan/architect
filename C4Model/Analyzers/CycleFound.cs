namespace C4Model.Analyzers;

public record CycleFound(IModel[] models) : Issue;
