using System.Reactive;
using ReactiveUI;
using Splat;

namespace VEGASTAR.ViewModels
{ 
    public class MainWindowViewModel : ReactiveObject, IScreen, IEnableLogger
    {
        public RoutingState Router { get; } = new RoutingState();
        
        public ReactiveCommand<Unit, IRoutableViewModel> GoNext { get; }
        
        public ReactiveCommand<Unit, Unit> GoBack => Router.NavigateBack;

        public MainWindowViewModel()
        {
            GoNext = ReactiveCommand.CreateFromObservable(
                () => Router.Navigate.Execute(new AdisLocalStorageViewModel(this))
            );
        }
    }
}