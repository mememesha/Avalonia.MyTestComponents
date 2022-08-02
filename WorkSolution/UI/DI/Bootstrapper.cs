using Microsoft.Extensions.Configuration;
using ReactiveUI;
using Splat;
using Splat.Serilog;
using VEGASTAR.Controls;
using VEGASTAR.ViewModels;
using VEGASTAR.ViewModels.AdisLocalStorage;
using VEGASTAR.ViewModels.Pages;
using VEGASTAR.Views;

namespace VEGASTAR.DI;

public class Bootstrapper : IEnableLogger
{
    public static void Register(IMutableDependencyResolver services, IReadonlyDependencyResolver resolver)
    {
        services.RegisterConstant(AddJsonConfiguration("appsettings.json"));
        Locator.CurrentMutable.RegisterConstant<IScreen>(new MainWindowViewModel());
        services.Register(() => new Page1(), typeof(IViewFor<Page1ViewModel>));
        services.Register(() => new AdisLocalStorage(), typeof(IViewFor<AdisLocalStorageViewModel>));
        services.Register(() => new SubRouteUserControl(), typeof(IViewFor<SubRouteUserControlViewModel>));
        services.Register(() => new DarchView(), typeof(IViewFor<DarchViewModel>));
       
        services.UseSerilogFullLogger();
        //services.Register<IPlatformService>(() => new PlatformService());  // Call services.Register<T> and pass it lambda that creates instance of your service
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