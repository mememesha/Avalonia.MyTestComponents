using System;
using Avalonia;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;
using VEGASTAR.ViewModels;

namespace VEGASTAR.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        this.WhenActivated(disposables => { });
        AvaloniaXamlLoader.Load(this);
        Opened += OnOpened;
#if DEBUG
        this.AttachDevTools();
#endif    
    }

    private void OnOpened(object? sender, EventArgs e)
    {
        var context = DataContext as MainWindowViewModel;
        context!.Router.Navigate.Execute(new SubRouteUserControlViewModel(context));
    }
}