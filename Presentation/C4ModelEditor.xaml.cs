using Infrastructure;
using Vms;
using Vms.Implementations;

namespace Presentation;

public partial class C4ModelEditor : ContentPage
{
	public C4ModelEditor()
	{
		InitializeComponent();

		var services = new ServiceCollection();
		services.AddInfrastructure();
		services.AddVms();

		var provider = services.BuildServiceProvider();
		var factory = provider.GetRequiredService<IFactory>();

        BindingContext = factory.CreateWorkspace(new C4Model.Workspace());
	}
}
