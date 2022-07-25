using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;

namespace MshaControls.Controls;

public class MonthChecked:ListBox,IStyleable
{
    Type IStyleable.StyleKey => typeof(MonthChecked);
    
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
}