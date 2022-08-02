using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using ReactiveUI;
using Splat;
using VEGASTAR.ViewModels;
using VEGASTAR.Views;

namespace VEGASTAR;

public class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = Locator.Current.GetService<IScreen>()
            };

            RxApp.DefaultExceptionHandler = new GlobalErrorHandler();
        }

        base.OnFrameworkInitializationCompleted();
    }
}