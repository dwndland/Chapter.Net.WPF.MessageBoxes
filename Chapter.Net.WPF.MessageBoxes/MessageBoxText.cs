// -----------------------------------------------------------------------------------------------------------------
// <copyright file="MessageBoxText.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System.Windows;
using System.Windows.Controls;

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WPF.MessageBoxes;

/// <summary>
///     Represents the text block used in the MessageBox.
/// </summary>
public class MessageBoxText : ContentControl
{
    static MessageBoxText()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(MessageBoxText), new FrameworkPropertyMetadata(typeof(MessageBoxText)));
    }
}