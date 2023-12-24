// -----------------------------------------------------------------------------------------------------------------
// <copyright file="MessageBoxButton.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System.Windows;
using System.Windows.Controls;

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WPF.MessageBoxes;

/// <summary>
///     Represents a button used in the <see cref="MessageBox" />.
/// </summary>
public class MessageBoxButton : Button
{
    static MessageBoxButton()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(MessageBoxButton), new FrameworkPropertyMetadata(typeof(MessageBoxButton)));
    }
}