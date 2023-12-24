// -----------------------------------------------------------------------------------------------------------------
// <copyright file="MessageBoxScrollViewer.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System.Windows;
using System.Windows.Controls;

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WPF.MessageBoxes;

/// <summary>
///     Represents the ScrollViewer used in the MessageBox.
/// </summary>
public class MessageBoxScrollViewer : ScrollViewer
{
    static MessageBoxScrollViewer()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(MessageBoxScrollViewer), new FrameworkPropertyMetadata(typeof(MessageBoxScrollViewer)));
    }
}