using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Styling;

namespace MshaControls.Controls;

public class YearsChecked:ListBox,IStyleable
{
    Type IStyleable.StyleKey => typeof(YearsChecked);
    
    public ObservableCollection<int> ChooseItems  => new ()
    {
        DateTime.Now.Year,
        DateTime.Now.AddYears(-1).Year,
    };
}