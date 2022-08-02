using System;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;
using VEGASTAR.ViewModels.AdisLocalStorage;
using VEGASTAR.ViewModels.Pages;

namespace VEGASTAR.Views;

public partial class Page1 : ReactiveUserControl<Page1ViewModel>
{
    public Page1()
    {
        
        this.WhenActivated(disposables => {  });
        AvaloniaXamlLoader.Load(this);
    }

    protected override void OnDataContextChanged(EventArgs e)
    {
        var context = DataContext as Page1ViewModel;
        context?.Router.Navigate.Execute(new AdisLocalStorageViewModel(context));
    }
    
}