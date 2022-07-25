using System;
using System.Collections.ObjectModel;
using System.Reactive.Disposables;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace VEGASTAR.ViewModels;

public class AdisLocalStorageViewModel : ReactiveObject, IActivatableViewModel, IRoutableViewModel
{
    public AdisLocalStorageViewModel(IScreen screen)
    {
        HostScreen = screen;
        
        Activator = new ViewModelActivator();
        this.WhenActivated((CompositeDisposable disposables) =>
        {
            /* handle activation */
            Disposable
                .Create(() => { /* handle deactivation */ })
                .DisposeWith(disposables);
        });
    }

    public IScreen HostScreen { get; }

    public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);

    [Reactive]
    public string SelectedMonth
    {
        get;
        set;
    } 

    public ViewModelActivator Activator { get; }
}