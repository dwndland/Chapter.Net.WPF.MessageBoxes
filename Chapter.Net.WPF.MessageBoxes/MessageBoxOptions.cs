// -----------------------------------------------------------------------------------------------------------------
// <copyright file="MessageBoxOptions.cs" company="dwndland">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using Chapter.Net.WPF.Theming;

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WPF.MessageBoxes;

/// <summary>
///     Hols all available additional <see cref="MessageBox" /> options.
/// </summary>
public class MessageBoxOptions
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="MessageBoxOptions" /> class.
    /// </summary>
    public MessageBoxOptions()
    {
        WindowOptions = new WindowOptionsContainer();
        Styles = new StylesContainer();

        MessageCopyFormatter = new DefaultMessageCopyFormatter();
        Strings = new MessageBoxStrings();

        ShowHelpButton = false;
        HelpRequestCallback = null;
        ShowYesToAllButton = false;
        ShowNoToAllButton = false;
        ShowDoNotShowAgainCheckBox = false;
        IsDoNotShowAgainChecked = false;
        ShowDetails = false;
        DetailsText = null;
    }

    /// <summary>
    ///     Gets or sets the message copy formatter to be called if the user pressed Ctrl+C with the Box open.
    /// </summary>
    public IMessageCopyFormatter MessageCopyFormatter { get; set; }

    /// <summary>
    ///     Gets or sets all strings to be used in the MessageBox buttons.
    /// </summary>
    public MessageBoxStrings Strings { get; set; }

    /// <summary>
    ///     Gets or sets a value which indicates if the MessageBox has a help button or not.
    /// </summary>
    public bool ShowHelpButton { get; set; }

    /// <summary>
    ///     Gets or sets the callback to be invoked after pressing the Help button.
    /// </summary>
    public Action HelpRequestCallback { get; set; }

    /// <summary>
    ///     Gets or sets a value which indicates if the MessageBox has a 'Yes To All' button.
    /// </summary>
    public bool ShowYesToAllButton { get; set; }

    /// <summary>
    ///     Gets or sets a value which indicates if the MessageBox has a 'No To All' button.
    /// </summary>
    public bool ShowNoToAllButton { get; set; }

    /// <summary>
    ///     Gets or sets a value which indicates if the MessageBox has a details button.
    /// </summary>
    public bool ShowDetails { get; set; }

    /// <summary>
    ///     Gets or sets a value which indicates if the MessageBox has a 'Do Not Show Again' checkbox.
    /// </summary>
    public bool ShowDoNotShowAgainCheckBox { get; set; }

    /// <summary>
    ///     Gets or sets a value which indicates if the 'Do Not Show Again' is checked on start and the check state after close
    ///     the MessageBox.
    /// </summary>
    public bool IsDoNotShowAgainChecked { get; set; }

    /// <summary>
    ///     Gets or sets the text to be shown in the details area.
    /// </summary>
    public string DetailsText { get; set; }

    /// <summary>
    ///     Holds all properties which affects the MessageBox window itself.
    /// </summary>
    public WindowOptionsContainer WindowOptions { get; }

    /// <summary>
    ///     Holds all properties for styling all UI elements.
    /// </summary>
    public StylesContainer Styles { get; }

    /// <summary>
    ///     Holds all properties for styling all UI elements.
    /// </summary>
    public class WindowOptionsContainer
    {
        internal WindowOptionsContainer()
        {
            Theme = WindowTheme.Light;
            ShowSystemMenu = false;
            Icon = null;
            StartupLocation = WindowStartupLocation.CenterOwner;
            ShowInTaskbar = false;
            ResizeMode = ResizeMode.NoResize;
            Position = new Point();
            MinWidth = 249;
            MaxWidth = 494;
            MinHeight = 172;
            MaxHeight = double.PositiveInfinity;
            DetailedMinWidth = 249;
            DetailedMaxWidth = 494;
            DetailedMinHeight = 350;
            DetailedMaxHeight = double.PositiveInfinity;
            DetailedResizeMode = ResizeMode.NoResize;
        }

        /// <summary>
        ///     Gets or sets the theme to use for the message box window.
        /// </summary>
        [DefaultValue(WindowTheme.Light)]
        public WindowTheme Theme { get; set; }

        /// <summary>
        ///     Gets or sets a value which indicates of the window has a system menu and icon.
        /// </summary>
        [DefaultValue(false)]
        public bool ShowSystemMenu { get; set; }

        /// <summary>
        ///     Gets or sets the icon to be used.
        /// </summary>
        [DefaultValue(null)]
        public ImageSource Icon { get; set; }

        /// <summary>
        ///     Gets or sets the startup location of the window.
        /// </summary>
        [DefaultValue(WindowStartupLocation.CenterOwner)]
        public WindowStartupLocation StartupLocation { get; set; }

        /// <summary>
        ///     Gets or sets a value which indicates if the window is shown in the task bar.
        /// </summary>
        [DefaultValue(false)]
        public bool ShowInTaskbar { get; set; }

        /// <summary>
        ///     Gets or sets a value which indicates if and how the window can be resized if the details are closed.
        /// </summary>
        [DefaultValue(ResizeMode.NoResize)]
        public ResizeMode ResizeMode { get; set; }

        /// <summary>
        ///     Gets or sets the position of the MessageBox.
        /// </summary>
        public Point Position { get; set; }

        /// <summary>
        ///     Gets or sets the minimum width of the MessageBox if details are closed.
        /// </summary>
        [DefaultValue(249)]
        public double MinWidth { get; set; }

        /// <summary>
        ///     Gets or sets the maximum width of the MessageBox if details are closed.
        /// </summary>
        [DefaultValue(494)]
        public double MaxWidth { get; set; }

        /// <summary>
        ///     Gets or sets the minimum height of the MessageBox if details are closed.
        /// </summary>
        [DefaultValue(172)]
        public double MinHeight { get; set; }

        /// <summary>
        ///     Gets or sets the maximum height of the MessageBox if details are closed.
        /// </summary>
        [DefaultValue(double.PositiveInfinity)]
        public double MaxHeight { get; set; }

        /// <summary>
        ///     Gets or sets the minimum width of the MessageBox if details are open.
        /// </summary>
        [DefaultValue(249)]
        public double DetailedMinWidth { get; set; }

        /// <summary>
        ///     Gets or sets the maximum width of the MessageBox if details are open.
        /// </summary>
        [DefaultValue(494)]
        public double DetailedMaxWidth { get; set; }

        /// <summary>
        ///     Gets or sets the minimum height of the MessageBox if details are open.
        /// </summary>
        [DefaultValue(350)]
        public double DetailedMinHeight { get; set; }

        /// <summary>
        ///     Gets or sets the maximum height of the MessageBox if details are open.
        /// </summary>
        [DefaultValue(double.PositiveInfinity)]
        public double DetailedMaxHeight { get; set; }

        /// <summary>
        ///     Gets or sets a value which indicates if and how the window can be resized if the details are open.
        /// </summary>
        [DefaultValue(ResizeMode.NoResize)]
        public ResizeMode DetailedResizeMode { get; set; }
    }

    /// <summary>
    ///     Holds all properties for styling all UI elements.
    /// </summary>
    public class StylesContainer
    {
        internal StylesContainer()
        {
            ImageStyle = null;
            ScrollViewerStyle = null;
            TextStyle = null;
            ButtonsPanelStyle = null;
            ButtonStyle = null;
            CheckBoxStyle = null;
            ExpanderStyle = null;
            DetailsPresenterStyle = null;
            Theme = WindowTheme.Light;
        }

        /// <summary>
        ///     Gets or sets the style to be used in the <see cref="MessageBoxImage" />.
        /// </summary>
        public Style ImageStyle { get; set; }

        /// <summary>
        ///     Gets or sets the style to be used in the <see cref="MessageBoxScrollViewer" />.
        /// </summary>
        public Style ScrollViewerStyle { get; set; }

        /// <summary>
        ///     Gets or sets the style to be used in the <see cref="MessageBoxText" />.
        /// </summary>
        public Style TextStyle { get; set; }

        /// <summary>
        ///     Gets or sets the style to be used in the <see cref="MessageBoxButtonsPanel" />.
        /// </summary>
        public Style ButtonsPanelStyle { get; set; }

        /// <summary>
        ///     Gets or sets the style to be used in the <see cref="MessageBoxButton" />.
        /// </summary>
        public Style ButtonStyle { get; set; }

        /// <summary>
        ///     Gets or sets the style to be used in the <see cref="MessageBoxCheckBox" />.
        /// </summary>
        public Style CheckBoxStyle { get; set; }

        /// <summary>
        ///     Gets or sets the style to be used in the <see cref="MessageBoxExpander" />.
        /// </summary>
        public Style ExpanderStyle { get; set; }

        /// <summary>
        ///     Gets or sets the style to be used in the <see cref="MessageBoxDetailsPresenter" />.
        /// </summary>
        public Style DetailsPresenterStyle { get; set; }

        /// <summary>
        ///     Defines how the window controls shall look like before apply the concrete styles.
        /// </summary>
        public WindowTheme? Theme { get; set; }
    }
}