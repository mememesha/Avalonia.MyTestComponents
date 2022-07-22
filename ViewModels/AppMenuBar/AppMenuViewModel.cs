using System.Collections.ObjectModel;
using System.Linq;
using ReactiveUI;

namespace VEGASTAR.ViewModels.AppMenuBar;

public class AppMenuViewModel : ReactiveObject
{
    public ObservableCollection<AppBarMenuItem> BarMenuItems { get; set; }

    public AppMenuViewModel()
    {
        BarMenuItems = new ObservableCollection<AppBarMenuItem>
        {
            new AppBarMenuItem() { Caption = "Загрузка" , Icon = "fa-solid fa-bars-progress"},
            new AppBarMenuItem() { Caption = "Архивы" , Icon = "fa-thin fa-box-archive"},
            new AppBarMenuItem() { Caption = "Карты" , Icon = "fa-solid fa-file-arrow-up"},
        };

        selectedMenuItem = selectedMenuItem ?? BarMenuItems.First();
    }
    
    private AppBarMenuItem selectedMenuItem;
    public AppBarMenuItem SelectedMenuItem
    {
        get => selectedMenuItem;
        set => this.RaiseAndSetIfChanged(ref selectedMenuItem, value);
    }
    
}