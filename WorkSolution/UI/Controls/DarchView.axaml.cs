using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;
using VEGASTAR.ViewModels.AdisLocalStorage;

namespace VEGASTAR.Controls;

public partial class DarchView : ReactiveUserControl<DarchViewModel>
{
    public DarchView()
    {
        this.WhenActivated(disposables =>
        {
            
        });
        AvaloniaXamlLoader.Load(this);
    }
}