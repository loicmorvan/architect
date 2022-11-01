using C4Model;

namespace Infrastructure;
internal class WorkspaceRepository : IWorkspaceRepository
{
    private readonly Dictionary<Guid, Workspace> workspaces = new();

    public Task<Guid> CreateAsync(CancellationToken token = default)
    {
        var id = Guid.NewGuid();
        var workspace = new Workspace();

        workspaces.Add(id, workspace);

        return Task.FromResult(id);
    }

    public Task DeleteAsync(Guid workspaceId, CancellationToken token = default)
    {
        workspaces.Remove(workspaceId);

        return Task.CompletedTask;
    }

    public Task<Workspace> ReadAsync(Guid workspaceId, CancellationToken token = default)
    {
        return Task.FromResult(workspaces[workspaceId]);
    }

    public Task UpdateAsync(Workspace workspace, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }
}
