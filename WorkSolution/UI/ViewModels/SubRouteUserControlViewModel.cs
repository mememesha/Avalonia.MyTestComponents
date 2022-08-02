using System;
using ReactiveUI;


namespace VEGASTAR.ViewModels;

public class SubRouteUserControlViewModel : ReactiveObject, IRoutableViewModel
{
    public IScreen HostScreen { get; }
    
    public SubRouteUserControlViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
    
    public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);
}