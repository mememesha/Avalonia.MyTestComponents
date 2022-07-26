using Microsoft.Extensions.Configuration;
using ReactiveUI;
using Splat;
using Splat.Serilog;
using VEGASTAR.ViewModels;
using VEGASTAR.ViewModels.AdisLocalStorage;
using VEGASTAR.Views;

namespace VEGASTAR.DI;

public class Bootstrapper : IEnableLogger
{
    public static void Register(IMutableDependencyResolver services, IReadonlyDependencyResolver resolver)
    {
        services.RegisterConstant(AddJsonConfiguration("appsettings.json"));
        services.Register(() => new AdisLocalStorage(), typeof(IViewFor<AdisLocalStorageViewModel>));
        services.Register(() => new SubRouteUserControl(), typeof(IViewFor<SubRouteUserControlViewModel>));
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