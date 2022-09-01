using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Media;
using Avalonia.Platform;
using Avalonia.Threading;

namespace MshaControls.HamburgerMenu
{
    public class HamburgerMenu : TabControl
    {
        private SplitView? _splitView;
        private ToggleButton? _homeButton;
        private Timer? timer;
        
        public static Dispatcher UIThread { get; } =
            new Dispatcher(AvaloniaLocator.Current.GetService<IPlatformThreadingInterface>());

        
        public static readonly StyledProperty<IBrush> PaneBackgroundProperty =
            SplitView.PaneBackgroundProperty.AddOwner<HamburgerMenu>();

        public IBrush PaneBackground
        {
            get => GetValue(PaneBackgroundProperty);
            set => SetValue(PaneBackgroundProperty, value);
        }

        public static readonly StyledProperty<IBrush> ContentBackgroundProperty =
            AvaloniaProperty.Register<HamburgerMenu, IBrush>(nameof(ContentBackground));

        public IBrush ContentBackground
        {
            get => GetValue(ContentBackgroundProperty);
            set => SetValue(ContentBackgroundProperty, value);
        }

        public static readonly StyledProperty<IBrush> XForegraundProperty =
            AvaloniaProperty.Register<HamburgerMenu, IBrush>(nameof(XForegraund), new SolidColorBrush(Colors.Black));

        public IBrush XForegraund
        {
            get => GetValue(XForegraundProperty);
            set => SetValue(XForegraundProperty, value);
        }
        
        public static readonly StyledProperty<IBrush> ContentOpeningForegraundProperty =
            AvaloniaProperty.Register<HamburgerMenu, IBrush>(nameof(ContentOpeningForegraund), new SolidColorBrush(Colors.Black));

        public IBrush ContentOpeningForegraund
        {
            get => GetValue(ContentOpeningForegraundProperty);
            set => SetValue(ContentOpeningForegraundProperty, value);
        }
        
        public static readonly StyledProperty<IBrush> ContentClosingForegraundProperty =
            AvaloniaProperty.Register<HamburgerMenu, IBrush>(nameof(ContentClosingForegraund), new SolidColorBrush(Colors.Black));

        public IBrush ContentClosingForegraund
        {
            get => GetValue(ContentClosingForegraundProperty);
            set => SetValue(ContentClosingForegraundProperty, value);
        }
        
        public static readonly StyledProperty<int> ExpandedModeThresholdWidthProperty =
            AvaloniaProperty.Register<HamburgerMenu, int>(nameof(ExpandedModeThresholdWidth), 1008);

        public int ExpandedModeThresholdWidth
        {
            get => GetValue(ExpandedModeThresholdWidthProperty);
            set => SetValue(ExpandedModeThresholdWidthProperty, value);
        }
      
        protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
        {
            base.OnApplyTemplate(e);
            _splitView = e.NameScope.Find<SplitView>("PART_NavigationPane");
            _homeButton = e.NameScope.Find<ToggleButton>("HamburgerMenuButton");
            _splitView.PaneClosing += SplitViewOnPaneClosed;
            _splitView.PaneOpened += SplitViewOnPaneOpened;
        }
        private void SplitViewOnPaneOpened(object? sender, EventArgs e)
        {
            XForegraund = ContentOpeningForegraund;
            timer?.Dispose();
            timer = new Timer(closeFormCallBack, null, 5000,5000);
        }

        private void closeFormCallBack(object? state)
        {
            UIThread.InvokeAsync(() =>
            {
                if (!((_splitView!.Pane as Control)!).IsPointerOver && _splitView.IsPaneOpen)
                {
                    _splitView.IsPaneOpen = false;
                    timer?.Dispose();
                }
            }).GetAwaiter().GetResult();
        }
        
        private void SplitViewOnPaneClosed(object? sender, EventArgs e)
        {
            XForegraund = ContentClosingForegraund;
            timer?.Dispose();
        }
    }
}