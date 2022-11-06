using Application;
using Infrastructure;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Shell.Implementations;
using Shell.Interfaces;
using System.Windows;

namespace Shell;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var services = new ServiceCollection();
        services.AddTransient<IMainVm, MainVm>();
        services.AddTypedFactory<IVmFactory>();
        services.AddMediatR(typeof(AssemblyMarker));
        services.AddInfrastructure();

        var serviceProvider = services.BuildServiceProvider();

        DataContext = serviceProvider.GetService<IMainVm>();
    }
}

internal static class ServiceCollectionEx
{
    public static IServiceCollection AddTypedFactory<TFactory>(this IServiceCollection services)
    {
        services.Add(new ServiceDescriptor(typeof(TFactory), typeof(VmFactory), ServiceLifetime.Singleton));

        return services;
    }
}
