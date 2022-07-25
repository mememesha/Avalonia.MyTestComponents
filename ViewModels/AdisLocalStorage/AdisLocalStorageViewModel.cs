using System;
using System.Collections.ObjectModel;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace VEGASTAR.ViewModels;

public class AdisLocalStorageViewModel : ReactiveObject, IRoutableViewModel
{
    
    public AdisLocalStorageViewModel(IScreen screen)
    {
        HostScreen = screen;
    }

    public IScreen HostScreen { get; }

    public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);
    
    [Reactive]
    public string SelectedMonth { get; set; }
}