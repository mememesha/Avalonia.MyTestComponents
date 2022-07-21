using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
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
                desktop.Exit += DesktopOnExit;
                desktop.ShutdownRequested += DesktopOnShutdownRequested;
                    
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }

        private void DesktopOnShutdownRequested(object? sender, ShutdownRequestedEventArgs e)
        {
            Log.CloseAndFlush();
        }

        private void DesktopOnExit(object? sender, ControlledApplicationLifetimeExitEventArgs e)
        {
            Log.CloseAndFlush();
        }
    }
}