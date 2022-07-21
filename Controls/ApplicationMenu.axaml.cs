using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace VEGASTAR.Controls;

public partial class ApplicationMenu : UserControl
{
    public ApplicationMenu()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}