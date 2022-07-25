using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;
using VEGASTAR.ViewModels;

namespace VEGASTAR.Views;

public partial class AdisLocalStorage : ReactiveUserControl<AdisLocalStorageViewModel>
{
    public AdisLocalStorage()
    {
        this.WhenActivated(disposables => { });
        AvaloniaXamlLoader.Load(this);
    }
}