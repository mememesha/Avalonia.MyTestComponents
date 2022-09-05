using System;
using ReactiveUI;

namespace VEGASTAR.ViewModels;

public class AutorizationViewModel : ReactiveObject, IRoutableViewModel
{
    public IScreen HostScreen { get; }
    
    public AutorizationViewModel(IScreen screen = null)
    {
        HostScreen = screen;
    }
    
    public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);
}