namespace C4Model;

public interface IWorkspaceRepository
{
    Task<Guid> CreateAsync(CancellationToken token = default);
    Task<Workspace> ReadAsync(Guid workspaceId, CancellationToken token = default);
    Task UpdateAsync(Workspace workspace, CancellationToken token = default);
    Task DeleteAsync(Guid workspaceId, CancellationToken token = default);
}
