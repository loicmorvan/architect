namespace C4Model.Analyzers;

public interface IAnalyzer
{
    IEnumerable<Issue> Analyze(Workspace workspace);
}
