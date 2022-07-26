using Avalonia.Controls;
using Avalonia.Styling;
using MshaControls.Models;

namespace MshaControls.Controls;

public class MonthChecked:ListBox,IStyleable
{
    Type IStyleable.StyleKey => typeof(MonthChecked);
    
    public static List<Month> MonthItems { get; } = new()
    {
        new Month("Янв."),
        new Month("Фев."),
        new Month("Мар."),
        new Month("Апр."),
        new Month("Май."),
        new Month("Июн."),
        new Month("Июл."),
        new Month("Авг."),
        new Month("Сен."),
        new Month("Окт."),
        new Month("Ноя."),
        new Month("Дек.")
    };
}