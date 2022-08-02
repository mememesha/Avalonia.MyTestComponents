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
        AvaloniaXamlLoader.Load(this);
    }
}