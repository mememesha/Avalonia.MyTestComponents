using System;
using System.Reactive.Disposables;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace VEGASTAR.ViewModels.AdisLocalStorage;

public class AdisLocalStorageViewModel : ReactiveObject, IActivatableViewModel, IRoutableViewModel
{
    #region private Properties

    

    #endregion

    #region public Properties

    public IScreen HostScreen { get; }

    public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);
    public ViewModelActivator Activator { get; }
    
    [Reactive]
    public string? SelectedMonth
    {
        get;
        set;
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
        this.WhenActivated(disposables =>
        {
            Disposable
                .Create(() => {})
                .DisposeWith(disposables);
        });
    }

    #endregion
}