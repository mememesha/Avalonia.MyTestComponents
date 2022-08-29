using ReactiveUI;

namespace VEGASTAR.ViewModels;

public class MainWindowViewModel : ReactiveObject, IScreen
{
    private RoutingState _router = new RoutingState();
    
    public RoutingState Router
    {
        get => _router;
        set => this.RaiseAndSetIfChanged(ref _router, value);
    }
}