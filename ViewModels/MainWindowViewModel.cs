using ReactiveUI;

namespace VEGASTAR.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private bool state;
        private bool IsOpen
        {
            get => state;
            set => this.RaisePropertyChanged(nameof(IsOpen));
        }
    }
}