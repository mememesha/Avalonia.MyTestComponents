using System;

namespace VEGASTAR.ViewModels.AppMenuBar;

public class AppBarMenuItem
{
    public string? Caption { get; set; }

    public string? Icon { get; set; }

    public Type? RouteViewModel { get; set; }
}