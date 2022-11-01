using C4Model;
using MediatR;

namespace Application;

public record WorkspaceCreated(Guid WorkspaceId);
public record NewWorkspace: IRequest<WorkspaceCreated>;

public class NewWorkspaceHandler : IRequestHandler<NewWorkspace, WorkspaceCreated>
{
    private readonly IWorkspaceRepository workspaceRepository;

    public NewWorkspaceHandler(IWorkspaceRepository workspaceRepository)
    {
        this.workspaceRepository = workspaceRepository;
    }

    public async Task<WorkspaceCreated> Handle(NewWorkspace request, CancellationToken cancellationToken)
    {
        return new (await workspaceRepository.CreateAsync(cancellationToken));
    }
}
