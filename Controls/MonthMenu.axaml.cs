using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Markup.Xaml;

namespace VEGASTAR.Controls;

public partial class MonthMenu : UserControl
{
    public static readonly StyledProperty<string> SelectedItemProperty =
        AvaloniaProperty.Register<MonthMenu, string>(nameof(SelectedItem));

    public string SelectedItem
    {
        get => GetValue(SelectedItemProperty);
        set => SetValue(SelectedItemProperty,value);
    }
    
    public MonthMenu()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void SelectingItemsControl_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
       
    }
}