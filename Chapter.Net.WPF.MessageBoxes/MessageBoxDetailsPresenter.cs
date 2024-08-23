// -----------------------------------------------------------------------------------------------------------------
// <copyright file="MessageBoxDetailsPresenter.cs" company="dwndland">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WPF.MessageBoxes;

/// <summary>
///     Holds the details content shown if details in the <see cref="MessageBox" /> are expanded.
/// </summary>
public class MessageBoxDetailsPresenter : Control
{
    /// <summary>
    ///     Identifies the <see cref="IsDetailsExpanded" /> dependency property.
    /// </summary>
    public static readonly DependencyProperty IsDetailsExpandedProperty =
        DependencyProperty.Register(nameof(IsDetailsExpanded), typeof(bool), typeof(MessageBoxDetailsPresenter), new UIPropertyMetadata(false));

    /// <summary>
    ///     Identifies the <see cref="Text" /> dependency property.
    /// </summary>
    public static readonly DependencyProperty TextProperty =
        DependencyProperty.Register(nameof(Text), typeof(string), typeof(MessageBoxDetailsPresenter), new PropertyMetadata(null));

    static MessageBoxDetailsPresenter()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(MessageBoxDetailsPresenter), new FrameworkPropertyMetadata(typeof(MessageBoxDetailsPresenter)));
    }

    /// <summary>
    ///     Gets or sets a value which indicates if the details are visible or not.
    /// </summary>
    /// <value>Default: false.</value>
    [DefaultValue(false)]
    public bool IsDetailsExpanded
    {
        get => (bool)GetValue(IsDetailsExpandedProperty);
        set => SetValue(IsDetailsExpandedProperty, value);
    }

    /// <summary>
    ///     Gets or sets the text shown in the details.
    /// </summary>
    /// <value>Default: null.</value>
    [DefaultValue(null)]
    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    internal void TakeStyles(MessageBoxOptions.StylesContainer styles)
    {
        TryApplyStyle<MessageBoxScrollViewer>(styles.ScrollViewerStyle);
    }

    private void TryApplyStyle<T>(Style style) where T : FrameworkElement
    {
        if (style == null)
            return;

        var controls = VisualTreeAssist.GetChildren<T>(this);
        foreach (var control in controls)
            control.Style = style;
    }
}