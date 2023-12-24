// -----------------------------------------------------------------------------------------------------------------
// <copyright file="MessageBoxImage.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System.ComponentModel;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Media.Imaging;

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WPF.MessageBoxes;

/// <summary>
///     Represents the icon shown in the MessageBox.
/// </summary>
public class MessageBoxImage : Control
{
    /// <summary>
    ///     Identifies the <see cref="MessageBoxImage.Image" /> dependency property.
    /// </summary>
    public static readonly DependencyProperty ImageProperty =
        DependencyProperty.Register(nameof(Image), typeof(MessageBoxImages), typeof(MessageBoxImage), new PropertyMetadata(MessageBoxImages.None, OnImageChanged));

    /// <summary>
    ///     Identifies the <see cref="BitmapSource" /> dependency property.
    /// </summary>
    public static readonly DependencyProperty BitmapSourceProperty =
        DependencyProperty.Register(nameof(BitmapSource), typeof(BitmapSource), typeof(MessageBoxImage), new PropertyMetadata(null));

    static MessageBoxImage()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(MessageBoxImage), new FrameworkPropertyMetadata(typeof(MessageBoxImage)));
    }

    /// <summary>
    ///     Gets or sets the image to be shown.
    /// </summary>
    /// <value>Default: MessageBoxImages.None.</value>
    [DefaultValue(MessageBoxImages.None)]
    public MessageBoxImages Image
    {
        get => (MessageBoxImages)GetValue(ImageProperty);
        set => SetValue(ImageProperty, value);
    }

    /// <summary>
    ///     Gets or sets the BitmapSource which represents the image to show.
    /// </summary>
    /// <value>Default: null.</value>
    [DefaultValue(null)]
    public BitmapSource BitmapSource
    {
        get => (BitmapSource)GetValue(BitmapSourceProperty);
        set => SetValue(BitmapSourceProperty, value);
    }

    private static void OnImageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var control = (MessageBoxImage)d;
        control.OnImageChanged();
    }

    private void OnImageChanged()
    {
        BitmapSource = Image switch
        {
            //MessageBoxImages.Error:
            //MessageBoxImages.Hand:
            MessageBoxImages.Stop => IconToImage(SystemIcons.Error),
            //MessageBoxImages.Exclamation:
            MessageBoxImages.Warning => IconToImage(SystemIcons.Warning),
            //MessageBoxImages.Asterisk:
            MessageBoxImages.Information => IconToImage(SystemIcons.Information),
            MessageBoxImages.Question => IconToImage(SystemIcons.Question),
            _ => BitmapSource
        };
    }

    private BitmapSource IconToImage(Icon icon)
    {
        return Imaging.CreateBitmapSourceFromHIcon(icon.Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
    }
}