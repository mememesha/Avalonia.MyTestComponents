using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;
using Splat;
using VEGASTAR.ViewModels.AdisLocalStorage;

namespace VEGASTAR.Views;

public partial class AdisLocalStorage : ReactiveUserControl<AdisLocalStorageViewModel>
{
    public AdisLocalStorage()
    {
        this.WhenActivated(disposables => { });
        AvaloniaXamlLoader.Load(this);
        var mainRoutedHost = Locator.Current.GetService<IScreen>();
        DataContext = new AdisLocalStorageViewModel(mainRoutedHost);
    }
}