using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace VEGASTAR.Views;

public partial class Registration : UserControl
{
    public Registration()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}