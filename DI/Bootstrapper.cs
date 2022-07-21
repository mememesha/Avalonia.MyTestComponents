using ReactiveUI;
using Splat;
using Splat.Serilog;
using VEGASTAR.ViewModels;
using VEGASTAR.Views;

namespace VEGASTAR.DI;

public class Bootstrapper : IEnableLogger 
{  
    public static void Register(IMutableDependencyResolver services, IReadonlyDependencyResolver resolver)
    {
        services.Register(() => new AdisLocalStorage(), typeof(IViewFor<AdisLocalStorageViewModel>));
        services.UseSerilogFullLogger();
        //services.Register<IPlatformService>(() => new PlatformService());  // Call services.Register<T> and pass it lambda that creates instance of your service
        LogHost.Default.Info("Application Starting...");
    }
} 