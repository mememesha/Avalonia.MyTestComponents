using System;
using System.Linq;
using System.Reactive.Disposables;
using MshaControls.Controls;
using MshaControls.Models;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace VEGASTAR.ViewModels.AdisLocalStorage;

public class AdisLocalStorageViewModel : ReactiveObject, IActivatableViewModel, IRoutableViewModel
{
    #region private Properties

    private Month? _month;

    #endregion

    #region public Properties

    public IScreen HostScreen { get; }

    public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);
    public ViewModelActivator Activator { get; }
    
    [Reactive]
    public Month? SelectedMonth
    {
        get => _month;
        set => this.RaiseAndSetIfChanged(ref _month, value);
    } 
    
    [Reactive]
    public int? SelectedYear
    {
        get;
        set;
    } 

    #endregion

    #region Constructor

    public AdisLocalStorageViewModel(IScreen screen)
    {
        HostScreen = screen;
        Activator = new ViewModelActivator();
        SelectedMonth = MonthChecked.MonthItems.ElementAt(5);
        
        this.WhenActivated(disposables =>
        {
            Disposable
                .Create(() => {})
                .DisposeWith(disposables);
        });
    }

    #endregion
}