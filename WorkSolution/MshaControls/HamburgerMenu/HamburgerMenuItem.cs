using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Media;
using Avalonia.Media.Imaging;

namespace MshaControls.HamburgerMenu
{
    /// <summary>
    /// ported from https://github.com/alicanerdogan/HamburgerMenu
    /// </summary>
    public class HamburgerMenuItem : ListBoxItem
    {
        /// <summary>
        /// style key of this control
        /// </summary>
        public Type StyleKey => typeof(HamburgerMenuItem);

        private const string ImageCtrlName = "menuImage";
        private Image _imageCtl;
     
        /// <summary>
        /// get/set Text
        /// </summary>
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        /// <summary>
        /// <see cref="Text"/>
        /// </summary>
        public static readonly StyledProperty<string> TextProperty =
            AvaloniaProperty.Register<HamburgerMenuItem, string>(nameof(Text));

        /// <summary>
        /// get/set IconLight
        /// </summary>
        public IBitmap IconLight
        {
            get { return (IBitmap)GetValue(IconLightProperty); }
            set { SetValue(IconLightProperty, value); }
        }

        /// <summary>
        /// <see cref="IconLight"/>
        /// </summary>
        public static readonly StyledProperty<IBitmap> IconLightProperty =
            AvaloniaProperty.Register<HamburgerMenuItem, IBitmap>(nameof(IconLight));

        /// <summary>
        /// get/set IconBlack
        /// </summary>
        public IBitmap IconBlack
        {
            get { return (IBitmap)GetValue(IconBlackProperty); }
            set { SetValue(IconBlackProperty, value); }
        }

        /// <summary>
        /// <see cref="IconBlack"/>
        /// </summary>
        public static readonly StyledProperty<IBitmap> IconBlackProperty =
            AvaloniaProperty.Register<HamburgerMenuItem, IBitmap>(nameof(IconBlack));

        /// <summary>
        /// get/set SelectionIndicatorColor
        /// </summary>
        public IBrush SelectionIndicatorColor
        {
            get { return (IBrush)GetValue(SelectionIndicatorColorProperty); }
            set { SetValue(SelectionIndicatorColorProperty, value); }
        }

        /// <summary>
        /// <see cref="SelectionIndicatorColor"/>
        /// </summary>
        public static readonly StyledProperty<IBrush> SelectionIndicatorColorProperty =
            AvaloniaProperty.Register<HamburgerMenuItem, IBrush>(nameof(SelectionIndicatorColor));

        /// <summary>
        /// get/sets SelectionCommand
        /// </summary>
        public ICommand SelectionCommand
        {
            get { return (ICommand)GetValue(SelectionCommandProperty); }
            set { SetValue(SelectionCommandProperty, value); }
        }

        /// <summary>
        /// <see cref="SelectionCommand"/>
        /// </summary>
        public static readonly StyledProperty<ICommand> SelectionCommandProperty =
            AvaloniaProperty.Register<HamburgerMenuItem, ICommand>(nameof(SelectionCommand));

        /// <summary>
        /// gets some controls from the style
        /// </summary>
        /// <param name="e"></param>
        protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
        {
            base.OnApplyTemplate(e);
            _imageCtl = e.NameScope.Find<Image>(ImageCtrlName);
            Button _button = e.NameScope.Find<Button>("ListBoxItemButton");
            _button.Tapped += (o, f) =>
            {
                this.IsSelected = true;
            };
        }

    }
}
