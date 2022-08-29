using System;
using ReactiveUI;
using Splat;


namespace VEGASTAR.ViewModels;

public class SubRouteUserControlViewModel : ReactiveObject, IRoutableViewModel, IEnableLogger
{
    public IScreen HostScreen { get; }
    
    public SubRouteUserControlViewModel(IScreen screen = null)
    {
        HostScreen = screen;
    }
    
    public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);
}