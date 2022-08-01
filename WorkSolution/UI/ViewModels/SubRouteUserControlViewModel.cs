using System;
using System.Collections.ObjectModel;
using System.Linq;
using ReactiveUI;
using VEGASTAR.ViewModels.AdisLocalStorage;
using VEGASTAR.ViewModels.AppMenuBar;

namespace VEGASTAR.ViewModels;

public class SubRouteUserControlViewModel : ReactiveObject, IScreen, IRoutableViewModel
{
    public SubRouteUserControlViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
    
    public IScreen HostScreen { get; }

    public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);

    public RoutingState Router { get; } = new RoutingState();
}