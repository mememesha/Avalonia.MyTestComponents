using System.Collections.ObjectModel;
using System.Linq;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace VEGASTAR.ViewModels;

public class MonthMenuControlViewModel : ReactiveObject
{
    public MonthMenuControlViewModel()
    {
        SelectedItem = MonthItems.First();
    }
    public ObservableCollection<string> MonthItems { get; } = new ObservableCollection<string>
    {
        "Янв.",
        "Фев.",
        "Мар.",
        "Апр.",
        "Май.",
        "Июн.",
        "Июл.",
        "Авг.",
        "Сен.",
        "Окт.",
        "Ноя.",
        "Дек."
    };

    [Reactive]
    public string SelectedItem { get; set; }
}