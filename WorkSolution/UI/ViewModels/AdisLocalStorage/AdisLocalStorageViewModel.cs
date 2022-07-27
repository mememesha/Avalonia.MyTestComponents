using System;
using System.Reactive.Disposables;
using MshaControls.Controls;
using MshaControls.Models;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
// ReSharper disable All

namespace VEGASTAR.ViewModels.AdisLocalStorage;

public class AdisLocalStorageViewModel : ReactiveObject, IActivatableViewModel, IRoutableViewModel,IScreen
{
    #region public Properties
    public IScreen HostScreen { get; }
    public RoutingState Router { get; } = new RoutingState();
    public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);
    public ViewModelActivator Activator { get; }

    [Reactive]
    public Month? SelectedMonth { get; set; }
    
    [Reactive]
    public int? SelectedYear { get; set; } 

    #endregion

    #region Constructor

    public AdisLocalStorageViewModel(IScreen screen)
    {
        HostScreen = screen;
        Activator = new ViewModelActivator();
        this.WhenActivated(disposables =>
        {
            Disposable
                .Create(() => { })
                .DisposeWith(disposables);
        });

        this.WhenAnyValue(c => c.SelectedMonth, c => c.SelectedYear).Subscribe(Navigate);
    }

    private void Navigate((Month?, int?) @params)
    {
        var (month, item2) = @params;
        
        if (month != null && item2 != null)
        {
            Router.Navigate.Execute(new DarchViewModel(this, MonthChecked.MonthItems.IndexOf(SelectedMonth!), SelectedYear));
        }
        else
        {
            //#todo notfound page
            //Router.NavigateAndReset.Execute(new DarchViewModel(this, MonthChecked.MonthItems.IndexOf(SelectedMonth), SelectedYear));
        }
    }

    #endregion
}