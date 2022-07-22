using System;
using System.Reactive;
using ReactiveUI;

namespace VEGASTAR.ViewModels;

public class SubRouteUserControlViewModel : ReactiveObject, IScreen, IRoutableViewModel
{
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);
    
    
    public RoutingState Router { get; } = new RoutingState();
    public ReactiveCommand<Unit, IRoutableViewModel> GoNext { get; }

    public ReactiveCommand<Unit, Unit> GoBack => Router.NavigateBack;
    

    public SubRouteUserControlViewModel(IScreen screen)
    {
        HostScreen = screen;
        
        
        
        GoNext = ReactiveCommand.CreateFromObservable(
            () => Router.Navigate.Execute(new AdisLocalStorageViewModel(this))
        );
    }
}