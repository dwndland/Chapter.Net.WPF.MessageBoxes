// -----------------------------------------------------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="dwndland">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System.Windows;
using Chapter.Net.WPF.MessageBoxes;
using Chapter.Net.WPF.Theming;
using MessageBox = System.Windows.MessageBox;
using MessageBoxOptions = Chapter.Net.WPF.MessageBoxes.MessageBoxOptions;
using MessageBoxResult = Chapter.Net.WPF.MessageBoxes.MessageBoxResult;

namespace Demo;

public partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();

        LoadDefaults();
        DataContext = this;
    }

    #region Styles

    public WindowTheme? ControlTheme { get; set; }

    #endregion

    private void OnShowClick(object sender, RoutedEventArgs e)
    {
        var options = new MessageBoxOptions();

        options.MessageCopyFormatter = new DefaultMessageCopyFormatter();
        options.ShowYesToAllButton = ShowYesToAllButton;
        options.ShowNoToAllButton = ShowNoToAllButton;
        options.ShowHelpButton = ShowHelpButton;
        options.HelpRequestCallback = () => MessageBox.Show(Owner, "Help!");
        options.ShowDoNotShowAgainCheckBox = ShowDoNotShowAgainCheckBox;
        options.ShowDetails = ShowDetails;
        options.DetailsText = DetailsText;

        options.WindowOptions.Theme = WindowTheme;
        options.WindowOptions.ShowSystemMenu = ShowSystemMenu;
        options.WindowOptions.StartupLocation = StartupLocation;
        options.WindowOptions.ShowInTaskbar = WindowShowInTaskbar;
        options.WindowOptions.ResizeMode = WindowResizeMode;
        options.WindowOptions.MinWidth = WindowMinWidth;
        options.WindowOptions.MaxWidth = WindowMaxWidth;
        options.WindowOptions.MinHeight = WindowMinHeight;
        options.WindowOptions.MaxHeight = WindowMaxHeight;
        options.WindowOptions.DetailedMinWidth = DetailedMinWidth;
        options.WindowOptions.DetailedMaxWidth = DetailedMaxWidth;
        options.WindowOptions.DetailedMinHeight = DetailedMinHeight;
        options.WindowOptions.DetailedMaxHeight = DetailedMaxHeight;
        options.WindowOptions.DetailedResizeMode = DetailedResizeMode;

        options.Strings.OK = OK;
        options.Strings.Cancel = Cancel;
        options.Strings.Abort = Abort;
        options.Strings.Retry = Retry;
        options.Strings.Ignore = Ignore;
        options.Strings.Yes = Yes;
        options.Strings.No = No;
        options.Strings.Help = Help;
        options.Strings.TryAgain = TryAgain;
        options.Strings.Continue = Continue;
        options.Strings.YesToAll = YesToAll;
        options.Strings.NoToAll = NoToAll;
        options.Strings.DoNotShowAgain = DoNotShowAgain;
        options.Strings.OpenDetails = OpenDetails;
        options.Strings.CloseDetails = CloseDetails;

        options.Styles.Theme = ControlTheme;

        Chapter.Net.WPF.MessageBoxes.MessageBox.Show(this, Message, Caption, Buttons, WindowIcon, DefaultButton, options);
    }

    private void LoadDefaults()
    {
        Caption = string.Empty;
        Message = string.Empty;
        Buttons = MessageBoxButtons.OK;
        WindowIcon = MessageBoxImages.None;
        DefaultButton = MessageBoxResult.OK;

        var options = new MessageBoxOptions();

        ShowYesToAllButton = options.ShowYesToAllButton;
        ShowNoToAllButton = options.ShowNoToAllButton;
        ShowHelpButton = options.ShowHelpButton;
        ShowDoNotShowAgainCheckBox = options.ShowDoNotShowAgainCheckBox;
        ShowDetails = options.ShowDetails;
        DetailsText = null;

        WindowTheme = options.WindowOptions.Theme;
        ShowSystemMenu = options.WindowOptions.ShowSystemMenu;
        StartupLocation = options.WindowOptions.StartupLocation;
        WindowShowInTaskbar = options.WindowOptions.ShowInTaskbar;
        WindowResizeMode = options.WindowOptions.ResizeMode;
        WindowMinWidth = options.WindowOptions.MinWidth;
        WindowMaxWidth = options.WindowOptions.MaxWidth;
        WindowMinHeight = options.WindowOptions.MinHeight;
        WindowMaxHeight = options.WindowOptions.MaxHeight;
        DetailedMinWidth = options.WindowOptions.DetailedMinWidth;
        DetailedMaxWidth = options.WindowOptions.DetailedMaxWidth;
        DetailedMinHeight = options.WindowOptions.DetailedMinHeight;
        DetailedMaxHeight = options.WindowOptions.DetailedMaxHeight;
        DetailedResizeMode = options.WindowOptions.DetailedResizeMode;

        OK = options.Strings.OK;
        Cancel = options.Strings.Cancel;
        Abort = options.Strings.Abort;
        Retry = options.Strings.Retry;
        Ignore = options.Strings.Ignore;
        Yes = options.Strings.Yes;
        No = options.Strings.No;
        Help = options.Strings.Help;
        TryAgain = options.Strings.TryAgain;
        Continue = options.Strings.Continue;
        YesToAll = options.Strings.YesToAll;
        NoToAll = options.Strings.NoToAll;
        DoNotShowAgain = options.Strings.DoNotShowAgain;
        OpenDetails = options.Strings.OpenDetails;
        CloseDetails = options.Strings.CloseDetails;

        ControlTheme = null;
    }

    #region Options

    public bool ShowYesToAllButton { get; set; }
    public bool ShowNoToAllButton { get; set; }
    public bool ShowHelpButton { get; set; }
    public bool ShowDoNotShowAgainCheckBox { get; set; }
    public bool ShowDetails { get; set; }
    public string DetailsText { get; set; }

    #endregion

    #region General

    public string Caption { get; set; }
    public string Message { get; set; }
    public MessageBoxButtons Buttons { get; set; }
    public MessageBoxImages WindowIcon { get; set; }
    public MessageBoxResult DefaultButton { get; set; }

    #endregion

    #region WindowOptions

    public WindowTheme WindowTheme { get; set; }
    public bool ShowSystemMenu { get; set; }
    public WindowStartupLocation StartupLocation { get; set; }
    public bool WindowShowInTaskbar { get; set; }
    public ResizeMode WindowResizeMode { get; set; }
    public double WindowMinWidth { get; set; }
    public double WindowMaxWidth { get; set; }
    public double WindowMinHeight { get; set; }
    public double WindowMaxHeight { get; set; }
    public double DetailedMinWidth { get; set; }
    public double DetailedMaxWidth { get; set; }
    public double DetailedMinHeight { get; set; }
    public double DetailedMaxHeight { get; set; }
    public ResizeMode DetailedResizeMode { get; set; }

    #endregion

    #region Strings

    public string OK { get; set; }
    public string Cancel { get; set; }
    public string Abort { get; set; }
    public string Retry { get; set; }
    public string Ignore { get; set; }
    public string Yes { get; set; }
    public string No { get; set; }
    public string Help { get; set; }
    public string TryAgain { get; set; }
    public string Continue { get; set; }
    public string YesToAll { get; set; }
    public string NoToAll { get; set; }
    public string DoNotShowAgain { get; set; }
    public string OpenDetails { get; set; }
    public string CloseDetails { get; set; }

    #endregion
}