using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;
using VEGASTAR.ViewModels;

namespace VEGASTAR.Views;

public partial class Autorization : ReactiveUserControl<AutorizationViewModel>
{
    public Autorization()
    {
        this.WhenActivated(disposables => { });
        AvaloniaXamlLoader.Load(this);
    }
}