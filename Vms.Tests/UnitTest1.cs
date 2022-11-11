using System.Reactive.Linq;
using Microsoft.Extensions.DependencyInjection;
using Shell.Interfaces;

namespace Vms.Tests;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        var services = new ServiceCollection();
        services.AddVms();

        var provider = services.BuildServiceProvider();

        var mainVm = provider.GetRequiredService<IMainVm>();
        Assert.NotNull(mainVm);
        Assert.Null(mainVm.CurrentWorkspace);
        await mainVm.NewWorkspace.Execute();
        Assert.NotNull(mainVm.CurrentWorkspace);
    }
}
