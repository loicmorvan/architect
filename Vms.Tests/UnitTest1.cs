namespace Vms.Tests;

using Microsoft.Extensions.DependencyInjection;
using Shell;
using Shell.Implementations;
using Shell.Interfaces;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var services = new ServiceCollection();
        services.AddSingleton<IMainVm, MainVm>();
        services.AddTransient<IWorkspaceVm, WorkspaceVm>();
        services.AddTypedFactory<IVmFactory>();

        var provider = services.BuildServiceProvider();

        dynamic factory = provider.GetRequiredService<TypedFactory<IVmFactory>>();
        Assert.NotNull(factory);
        Assert.IsType<WorkspaceVm>(factory.CreateWorkspaceVm(Guid.NewGuid()));
    }
}
