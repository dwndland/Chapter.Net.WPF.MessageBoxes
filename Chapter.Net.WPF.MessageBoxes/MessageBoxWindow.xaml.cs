// 
// Copyright (c) David Wendland. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// 

using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using Chapter.Net.WPF.Behaviors;

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WPF.MessageBoxes;

/// <summary>
///     The WPF Message Box Window.
/// </summary>
public partial class MessageBoxWindow : INotifyPropertyChanged
{
    private bool _closeByButtons;
    private Size _oldMaxSize;

    private Size _oldMinSize;
    private Size _oldSize;

    internal MessageBoxWindow()
    {
        InitializeComponent();
        DataContext = this;

        Loaded += HandleLoaded;

        AddHandler(MessageBoxButtonsPanel.ClickEvent, (RoutedEventHandler)OnButtonClick);
        AddHandler(MessageBoxButtonsPanel.HelpRequestEvent, (RoutedEventHandler)OnHelpRequestClick);
        AddHandler(MessageBoxButtonsPanel.ExpandDetailsEvent, (RoutedEventHandler)OnExpandDetailsClick);
    }

    /// <summary>
    ///     Gets or sets a value which indicates of the details are shown or not
    /// </summary>
    public bool IsDetailsExpanded { get; set; }

    /// <summary>
    ///     Gets or sets the message to be show.
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    ///     Gets or sets the icon to show.
    /// </summary>
    public MessageBoxImages Image { get; set; }

    /// <summary>
    ///     Gets or sets which buttons has to be shown.
    /// </summary>
    public MessageBoxButtons Buttons { get; set; }

    /// <summary>
    ///     Gets or sets which button is the default button after showing the MessageBox.
    /// </summary>
    public MessageBoxResult DefaultButton { get; set; }

    /// <summary>
    ///     Gets or sets the result how the user closed the MessageBox.
    /// </summary>
    public MessageBoxResult Result { get; set; }

    /// <summary>
    ///     Gets or sets the additional MessageBox options.
    /// </summary>
    public MessageBoxOptions Options { get; set; }

    /// <summary>
    ///     Gets or sets the theme for the controls.
    /// </summary>
    public WindowTheme? ControlTheme { get; set; }

    /// <summary>
    ///     Occurs when a property value changes.
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    private void HandleLoaded(object sender, RoutedEventArgs e)
    {
        TryApplyStyle(PART_Image, Options.Styles.ImageStyle);
        TryApplyStyle(PART_ScrollViewer, Options.Styles.ScrollViewerStyle);
        TryApplyStyle(PART_Text, Options.Styles.TextStyle);
        TryApplyStyle(PART_ButtonPanel, Options.Styles.ButtonsPanelStyle);
        TryApplyStyle(PART_DetailsPresenter, Options.Styles.DetailsPresenterStyle);

        PART_ButtonPanel.TakeStyles(Options.Styles);
        PART_DetailsPresenter.TakeStyles(Options.Styles);
    }

    private void TryApplyStyle(FrameworkElement targetElement, Style style)
    {
        if (style != null)
            targetElement.Style = style;
    }

    private void OnExpandDetailsClick(object sender, RoutedEventArgs e)
    {
        IsDetailsExpanded = !IsDetailsExpanded;
        OnPropertyChanged(nameof(IsDetailsExpanded));

        if (IsDetailsExpanded)
        {
            UpperArea.Height = new GridLength(UpperArea.ActualHeight);
            LowerArea.Height = new GridLength(1, GridUnitType.Star);

            _oldMinSize = new Size(MinWidth, MinHeight);
            _oldMaxSize = new Size(MaxWidth, MaxHeight);
            _oldSize = new Size(Width, Height);

            MinWidth = Options.WindowOptions.DetailedMinWidth;
            MaxWidth = Options.WindowOptions.DetailedMaxWidth;
            MinHeight = Options.WindowOptions.DetailedMinHeight;
            MaxHeight = Options.WindowOptions.DetailedMaxHeight;

            ResizeMode = Options.WindowOptions.DetailedResizeMode;
        }
        else
        {
            UpperArea.Height = new GridLength(1, GridUnitType.Star);
            LowerArea.Height = new GridLength(0, GridUnitType.Auto);

            MinWidth = _oldMinSize.Width;
            MaxWidth = _oldMaxSize.Width;
            Width = _oldSize.Width;
            MinHeight = _oldMinSize.Height;
            MaxHeight = _oldMaxSize.Height;
            Height = _oldSize.Height;

            ResizeMode = Options.WindowOptions.ResizeMode;
        }
    }

    private void OnButtonClick(object sender, RoutedEventArgs e)
    {
        var panel = (MessageBoxButtonsPanel)e.OriginalSource;
        Result = panel.Result;

        _closeByButtons = true;
        DialogResult = true;
    }

    private void OnHelpRequestClick(object sender, RoutedEventArgs e)
    {
        Options.HelpRequestCallback?.Invoke();
    }

    /// <summary>
    ///     Raises the System.Windows.Window.SourceInitialized event.
    /// </summary>
    /// <param name="e">An System.EventArgs that contains the event data.</param>
    protected override void OnSourceInitialized(EventArgs e)
    {
        base.OnSourceInitialized(e);

        WindowBehavior.SetTheme(this, Options.WindowOptions.Theme);
        ControlTheme = Options.Styles.Theme == WindowTheme.System ? ThemeManager.GetSystemTheme() : Options.Styles.Theme;
        OnPropertyChanged(nameof(ControlTheme));
    }

    /// <summary>
    ///     Raises the System.Windows.Window.ContentRendered event.
    /// </summary>
    /// <param name="e">An System.EventArgs that contains the event data.</param>
    protected override void OnContentRendered(EventArgs e)
    {
        PART_ButtonPanel.Measure(new Size(double.MaxValue, double.MaxValue));
        var panelWidth = PART_ButtonPanel.DesiredSize.Width;

        if (!double.IsNaN(panelWidth))
        {
            if (panelWidth > MaxWidth)
                MaxWidth = panelWidth + 40;
            if (panelWidth > Options.WindowOptions.DetailedMaxWidth)
                Options.WindowOptions.DetailedMaxWidth = panelWidth + 40;
            if (panelWidth > MinWidth)
                MinWidth = panelWidth + 40;
            if (panelWidth > Options.WindowOptions.DetailedMinWidth)
                Options.WindowOptions.DetailedMinWidth = panelWidth + 40;
        }

        base.OnContentRendered(e);

        PART_ButtonPanel.SetDefaultButton();
    }

    /// <summary>
    ///     Raises the System.Windows.Window.Closing event.
    /// </summary>
    /// <param name="e">A System.ComponentModel.CancelEventArgs that contains the event data.</param>
    protected override void OnClosing(CancelEventArgs e)
    {
        if (!_closeByButtons && (Buttons == MessageBoxButtons.YesNo || Buttons == MessageBoxButtons.AbortRetryIgnore))
            e.Cancel = true;

        base.OnClosing(e);
    }

    /// <summary>
    ///     Invoked when an unhandled System.Windows.Input.Keyboard.PreviewKeyDown attached event reaches an element in its
    ///     route that is derived from this class. Implement this method to add class handling for this event.
    /// </summary>
    /// <param name="e">The System.Windows.Input.KeyEventArgs that contains the event data.</param>
    protected override void OnPreviewKeyDown(KeyEventArgs e)
    {
        base.OnPreviewKeyDown(e);

        if (e.Key == Key.C && Keyboard.Modifiers == ModifierKeys.Control && Options.MessageCopyFormatter != null)
            Options.MessageCopyFormatter.Copy(Title, Message, Options.DetailsText, Buttons, Image, Options.Strings);

        if (e.Key != Key.Escape)
            return;

        if (Buttons == MessageBoxButtons.AbortRetryIgnore || Buttons == MessageBoxButtons.YesNo)
            return;

        Close();
    }

    internal void SetWindowOptions(Window window, MessageBoxOptions.WindowOptionsContainer options)
    {
        window.WindowStartupLocation = options.StartupLocation;
        if (window.Owner == null && options.StartupLocation == WindowStartupLocation.CenterOwner)
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        if (window.WindowStartupLocation == WindowStartupLocation.Manual)
        {
            window.Left = options.Position.X;
            window.Top = options.Position.Y;
        }

        if (!Options.WindowOptions.ShowSystemMenu)
            WindowTitleBarBehavior.SetDisableSystemMenu(this, true);
        else if (Options.WindowOptions.Icon != null)
            Icon = Options.WindowOptions.Icon;

        if (Options.WindowOptions.ResizeMode == ResizeMode.NoResize)
        {
            WindowTitleBarBehavior.SetDisableMinimizeButton(this, true);
            WindowTitleBarBehavior.SetDisableMaximizeButton(this, true);
        }

        if (Buttons == MessageBoxButtons.YesNo || Buttons == MessageBoxButtons.AbortRetryIgnore)
            WindowTitleBarBehavior.SetDisableCloseButton(this, true);

        window.ResizeMode = options.ResizeMode;
        window.ShowInTaskbar = options.ShowInTaskbar;

        window.MinWidth = options.MinWidth;
        window.MaxWidth = options.MaxWidth;
        window.MinHeight = options.MinHeight;
        window.MaxHeight = options.MaxHeight;

        window.SizeToContent = SizeToContent.WidthAndHeight;
        window.SnapsToDevicePixels = true;
    }

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}