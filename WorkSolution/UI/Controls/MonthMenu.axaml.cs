using System;
using Avalonia;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;
using VEGASTAR.ViewModels;
#pragma warning disable CS8602


namespace VEGASTAR.Controls;

public partial class MonthMenu : ReactiveUserControl<MonthMenuControlViewModel>
{
    private string _item;
    public static readonly StyledProperty<string> SelectedItemProperty
        = AvaloniaProperty.Register<MonthMenu,string>("SelectedItem");
    
    public string SelectedItem
    {
        get => GetValue(SelectedItemProperty);
        set => SetAndRaise(SelectedItemProperty,ref _item,value);
    }
    
    public MonthMenu()
    {
        InitializeComponent();
        this.WhenAny(x => x.ViewModel.SelectedItem, x=>x.Value).Subscribe(x => SelectedItem = x);
    }

    private void InitializeComponent()
    {
        this.WhenActivated(disposables => { /* Handle view activation etc. */ });
        AvaloniaXamlLoader.Load(this);
    }
}