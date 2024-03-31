// -----------------------------------------------------------------------------------------------------------------
// <copyright file="MessageBoxExpander.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WPF.MessageBoxes
{
    /// <summary>
    ///     Represents the details button shown in the MessageBox.
    /// </summary>
    public class MessageBoxExpander : Expander
    {
        /// <summary>
        ///     Identifies the <see cref="CollapsedHeaderText" /> dependency property.
        /// </summary>
        public static readonly DependencyProperty CollapsedHeaderTextProperty =
            DependencyProperty.Register(nameof(CollapsedHeaderText), typeof(string), typeof(MessageBoxExpander), new UIPropertyMetadata(null));

        /// <summary>
        ///     Identifies the <see cref="ExpandedHeaderText" /> dependency property.
        /// </summary>
        public static readonly DependencyProperty ExpandedHeaderTextProperty =
            DependencyProperty.Register(nameof(ExpandedHeaderText), typeof(string), typeof(MessageBoxExpander), new UIPropertyMetadata(null));

        static MessageBoxExpander()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MessageBoxExpander), new FrameworkPropertyMetadata(typeof(MessageBoxExpander)));
        }

        /// <summary>
        ///     Gets or sets the text to show on the button if the details are not shown.
        /// </summary>
        /// <value>Default: null.</value>
        [DefaultValue(null)]
        public string CollapsedHeaderText
        {
            get => (string)GetValue(CollapsedHeaderTextProperty);
            set => SetValue(CollapsedHeaderTextProperty, value);
        }

        /// <summary>
        ///     Gets or sets the text to show on the button if the details are shown.
        /// </summary>
        /// <value>Default: null.</value>
        [DefaultValue(null)]
        public string ExpandedHeaderText
        {
            get => (string)GetValue(ExpandedHeaderTextProperty);
            set => SetValue(ExpandedHeaderTextProperty, value);
        }
    }
}