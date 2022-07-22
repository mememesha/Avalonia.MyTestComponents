using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;
using VEGASTAR.ViewModels;

namespace VEGASTAR.Views;

public partial class SubRouteUserControl : ReactiveUserControl<SubRouteUserControlViewModel>
{
    public SubRouteUserControl()
    {
        this.WhenActivated(disposables => { });
        this.Initialized+= OnInitialized;
        AvaloniaXamlLoader.Load(this);
        
    }

    private void OnInitialized(object? sender, EventArgs e)
    {
        var context = DataContext as SubRouteUserControlViewModel;
        context?.Router.Navigate.Execute(new AdisLocalStorageViewModel(context));
    }
}