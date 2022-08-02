using System;
using System.Reactive.Disposables;
using ReactiveUI;
using Splat;

namespace VEGASTAR.ViewModels.Pages;

public class Page1ViewModel: ReactiveObject, IScreen, IActivatableViewModel
{
    public ViewModelActivator Activator { get; }
    
    public Page1ViewModel()
    {
        Activator  = new ViewModelActivator();
        this.WhenActivated(disposables =>
        {
            /* Handle activation */
            Disposable
                .Create(() => { /* Handle deactivation */ })
                .DisposeWith(disposables);
        });
        
    }
    public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);

    public RoutingState Router { get; } = new RoutingState();
}