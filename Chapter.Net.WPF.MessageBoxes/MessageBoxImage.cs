// -----------------------------------------------------------------------------------------------------------------
// <copyright file="MessageBoxImage.cs" company="dwndland">
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
        switch (Image)
        {
            //MessageBoxImages.Error:
            //MessageBoxImages.Hand:
            case MessageBoxImages.Stop:
                BitmapSource = IconToImage(SystemIcons.Error);
                break;
            //MessageBoxImages.Exclamation:
            case MessageBoxImages.Warning:
                BitmapSource = IconToImage(SystemIcons.Warning);
                break;
            //MessageBoxImages.Asterisk:
            case MessageBoxImages.Information:
                BitmapSource = IconToImage(SystemIcons.Information);
                break;
            case MessageBoxImages.Question:
                BitmapSource = IconToImage(SystemIcons.Question);
                break;
            default:
                BitmapSource = BitmapSource;
                break;
        }
    }

    private BitmapSource IconToImage(Icon icon)
    {
        return Imaging.CreateBitmapSourceFromHIcon(icon.Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
    }
}