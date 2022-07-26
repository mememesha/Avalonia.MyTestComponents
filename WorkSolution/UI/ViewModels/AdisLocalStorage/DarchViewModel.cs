using System;
using System.Reactive.Disposables;
using ReactiveUI;

namespace VEGASTAR.ViewModels.AdisLocalStorage;

public class DarchViewModel : ReactiveObject, IActivatableViewModel, IRoutableViewModel
{
    private int _month;
    private int? _year;
    
    public IScreen HostScreen { get; }
    public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);
    public ViewModelActivator Activator { get; }

    public DarchViewModel(IScreen screen, int month, int? year)
    {
        _month = month;
        _year = year;
        HostScreen = screen;
        Activator = new ViewModelActivator();
        this.WhenActivated(disposables =>
        {
            Disposable
                .Create(() => { })
                .DisposeWith(disposables);
        });
    }
}