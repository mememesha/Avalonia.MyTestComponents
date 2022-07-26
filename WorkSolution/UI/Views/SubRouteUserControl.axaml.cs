using System;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;
using VEGASTAR.ViewModels;
using VEGASTAR.ViewModels.AdisLocalStorage;

namespace VEGASTAR.Views;

public partial class SubRouteUserControl : ReactiveUserControl<SubRouteUserControlViewModel>
{
    public SubRouteUserControl()
    {
        this.WhenActivated(disposables => { });
        Initialized += OnInitialized;
        AvaloniaXamlLoader.Load(this);
    }

    private void OnInitialized(object? sender, EventArgs e)
    {
        var context = DataContext as SubRouteUserControlViewModel;
        context?.Router.Navigate.Execute(new AdisLocalStorageViewModel(context));
    }
}