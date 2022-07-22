using System.Reactive;
using ReactiveUI;
using Splat;

namespace VEGASTAR.ViewModels
{ 
    public class MainWindowViewModel : ReactiveObject, IScreen, IEnableLogger
    {
        public RoutingState Router { get; } = new RoutingState();
       
    }
}