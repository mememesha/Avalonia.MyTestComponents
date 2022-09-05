using Microsoft.Extensions.Configuration;
using ReactiveUI;
using Splat;
using Splat.Serilog;
using VEGASTAR.Controls;
using VEGASTAR.ViewModels;
using VEGASTAR.ViewModels.AdisLocalStorage;
using VEGASTAR.Views;

namespace VEGASTAR.DI;

public class Bootstrapper : IEnableLogger
{
    public static void Register(IMutableDependencyResolver services, IReadonlyDependencyResolver resolver)
    {
        services.RegisterConstant(AddJsonConfiguration("appsettings.json"));
        Locator.CurrentMutable.RegisterConstant<IScreen>(new MainWindowViewModel());
        services.Register(() => new SubRouteUserControl(), typeof(IViewFor<SubRouteUserControlViewModel>));
        services.Register(()=> new Autorization(),typeof(IViewFor<AutorizationViewModel>) );
        services.Register(() => new DarchView(), typeof(IViewFor<DarchViewModel>));
        services.UseSerilogFullLogger();
        LogHost.Default.Info("Application Starting...");
    }

    public static IConfiguration AddJsonConfiguration(string path)
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile(path)
            .Build();
        return configuration;
    }
}