using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;
using VEGASTAR.ViewModels;
using VEGASTAR.ViewModels.AdisLocalStorage;

namespace VEGASTAR.Views;

public partial class AdisLocalStorage : ReactiveUserControl<AdisLocalStorageViewModel>
{
    public AdisLocalStorage()
    {
        this.WhenActivated(disposables => { });
        AvaloniaXamlLoader.Load(this);
    }
}