// -----------------------------------------------------------------------------------------------------------------
// <copyright file="MessageBoxCheckBox.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System.Windows;
using System.Windows.Controls;

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WPF.MessageBoxes
{
    /// <summary>
    ///     Represents the CheckBox used in the MessageBox.
    /// </summary>
    public class MessageBoxCheckBox : CheckBox
    {
        static MessageBoxCheckBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MessageBoxCheckBox), new FrameworkPropertyMetadata(typeof(MessageBoxCheckBox)));
        }
    }
}