using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using ReactiveUI;
using Serilog;
using VEGASTAR.ViewModels;
using VEGASTAR.Views;

namespace VEGASTAR
{
    public partial class App : Application
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
                    DataContext = new MainWindowViewModel(),
                };

                RxApp.DefaultExceptionHandler = new GlobalErrorHandler();
            }

            base.OnFrameworkInitializationCompleted();
        }
        
    }
}