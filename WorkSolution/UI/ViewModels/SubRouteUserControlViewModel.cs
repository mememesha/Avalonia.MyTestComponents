using System;
using System.Collections.ObjectModel;
using System.Linq;
using ReactiveUI;
using VEGASTAR.ViewModels.AppMenuBar;

namespace VEGASTAR.ViewModels;

public class SubRouteUserControlViewModel : ReactiveObject, IScreen, IRoutableViewModel
{
    private AppBarMenuItem _selectedMenuItem;

    public SubRouteUserControlViewModel(IScreen screen)
    {
        HostScreen = screen;

        BarMenuItems = new ObservableCollection<AppBarMenuItem>
        {
            new()
            {
                Caption = "Загрузка", Icon = "fa-solid fa-bars-progress",
                RouteViewModel = typeof(AdisLocalStorageViewModel)
            },
            new()
            {
                Caption = "Архивы", Icon = "fa-thin fa-box-archive", RouteViewModel = typeof(AdisLocalStorageViewModel)
            },
            new()
            {
                Caption = "Карты", Icon = "fa-solid fa-file-arrow-up",
                RouteViewModel = typeof(AdisLocalStorageViewModel)
            }
        };

        _selectedMenuItem = _selectedMenuItem ?? BarMenuItems.First();
    }

    public AppBarMenuItem SelectedMenuItem
    {
        get => _selectedMenuItem;
        set
        {
            this.RaiseAndSetIfChanged(ref _selectedMenuItem, value);
            if (_selectedMenuItem.RouteViewModel == typeof(AdisLocalStorageViewModel))
                Router.NavigateAndReset.Execute(new AdisLocalStorageViewModel(this));
        }
    }

    public ObservableCollection<AppBarMenuItem> BarMenuItems { get; set; }

    public IScreen HostScreen { get; }

    public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);

    public RoutingState Router { get; } = new RoutingState();
}