// -----------------------------------------------------------------------------------------------------------------
// <copyright file="MessageBox.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System;
using System.Windows;

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WPF.MessageBoxes;

/// <summary>
///     Show a WPF window as a message box which is full configurable.
/// </summary>
/// <example>
///     <code lang="csharp">
/// <![CDATA[
/// public void Show1()
/// {
///     MessageBox.Show("Messagebox Text");
/// }
/// 
/// public void Show2()
/// {
///     MessageBox.Show("Messagebox Text", "Caption");
/// }
/// 
/// public void Show3()
/// {
///     MessageBox.Show("Messagebox Text", "Caption", MessageBoxButtons.AbortRetryIgnore);
/// }
/// 
/// public void Show4()
/// {
///     var options = new MessageBoxOptions();
///     options.DetailsContent = new Label();
///     options.ShowDetails = true;
///     options.ShowHelpButton = true;
///     options.Strings.Abort = "Go Away";
///     options.WindowOptions.DetailedResizeMode = ResizeMode.CanResizeWithGrip;
/// 
///     MessageBox.Show("Messagebox Text",
///                     "Caption",
///                     MessageBoxButtons.AbortRetryIgnore,
///                     MessageBoxImages.Error,
///                     MessageBoxResult.Retry,
///                     options);
/// }
/// ]]>
/// </code>
/// </example>
public static class MessageBox
{
    /// <summary>
    ///     Displays a message box that has a message and that returns a result of the button the user pressed.
    /// </summary>
    /// <param name="messageBoxText">A String that specifies the text to display.</param>
    /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
    public static MessageBoxResult Show(string messageBoxText)
    {
        return Show(null, messageBoxText, string.Empty, MessageBoxButtons.OK, MessageBoxImages.None, MessageBoxResult.OK, new MessageBoxOptions());
    }

    /// <summary>
    ///     Displays a message box that has a message and that returns a result of the button the user pressed.
    /// </summary>
    /// <param name="messageBoxText">A String that specifies the text to display.</param>
    /// <param name="caption">A String that specifies the title bar caption to display.</param>
    /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
    public static MessageBoxResult Show(string messageBoxText, string caption)
    {
        return Show(null, messageBoxText, caption, MessageBoxButtons.OK, MessageBoxImages.None, MessageBoxResult.OK, new MessageBoxOptions());
    }

    /// <summary>
    ///     Displays a message box that has a message and that returns a result of the button the user pressed.
    /// </summary>
    /// <param name="messageBoxText">A String that specifies the text to display.</param>
    /// <param name="caption">A String that specifies the title bar caption to display.</param>
    /// <param name="buttons">A MessageBoxButtons value that specifies which buttons to display.</param>
    /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
    public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButtons buttons)
    {
        return Show(null, messageBoxText, caption, buttons, MessageBoxImages.None, MessageBoxResult.OK, new MessageBoxOptions());
    }

    /// <summary>
    ///     Displays a message box that has a message and that returns a result of the button the user pressed.
    /// </summary>
    /// <param name="messageBoxText">A String that specifies the text to display.</param>
    /// <param name="caption">A String that specifies the title bar caption to display.</param>
    /// <param name="buttons">A MessageBoxButtons value that specifies which buttons to display.</param>
    /// <param name="icon">A MessageBoxImages value that specifies the icon to display.</param>
    /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
    public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxImages icon)
    {
        return Show(null, messageBoxText, caption, buttons, icon, MessageBoxResult.OK, new MessageBoxOptions());
    }

    /// <summary>
    ///     Displays a message box that has a message and that returns a result of the button the user pressed.
    /// </summary>
    /// <param name="messageBoxText">A String that specifies the text to display.</param>
    /// <param name="caption">A String that specifies the title bar caption to display.</param>
    /// <param name="buttons">A MessageBoxButtons value that specifies which buttons to display.</param>
    /// <param name="icon">A MessageBoxImages value that specifies the icon to display.</param>
    /// <param name="defaultButton">A MessageBoxResult value that specifies the default result of the message box.</param>
    /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
    public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxImages icon, MessageBoxResult defaultButton)
    {
        return Show(null, messageBoxText, caption, buttons, icon, defaultButton, new MessageBoxOptions());
    }

    /// <summary>
    ///     Displays a message box that has a message and that returns a result of the button the user pressed.
    /// </summary>
    /// <param name="owner">A Window that represents the owner window of the message box.</param>
    /// <param name="messageBoxText">A String that specifies the text to display.</param>
    /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
    public static MessageBoxResult Show(Window owner, string messageBoxText)
    {
        return Show(owner, messageBoxText, string.Empty, MessageBoxButtons.OK, MessageBoxImages.None, MessageBoxResult.OK, new MessageBoxOptions());
    }

    /// <summary>
    ///     Displays a message box that has a message and that returns a result of the button the user pressed.
    /// </summary>
    /// <param name="owner">A Window that represents the owner window of the message box.</param>
    /// <param name="messageBoxText">A String that specifies the text to display.</param>
    /// <param name="caption">A String that specifies the title bar caption to display.</param>
    /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
    public static MessageBoxResult Show(Window owner, string messageBoxText, string caption)
    {
        return Show(owner, messageBoxText, caption, MessageBoxButtons.OK, MessageBoxImages.None, MessageBoxResult.OK, new MessageBoxOptions());
    }

    /// <summary>
    ///     Displays a message box that has a message and that returns a result of the button the user pressed.
    /// </summary>
    /// <param name="owner">A Window that represents the owner window of the message box.</param>
    /// <param name="messageBoxText">A String that specifies the text to display.</param>
    /// <param name="caption">A String that specifies the title bar caption to display.</param>
    /// <param name="buttons">A MessageBoxButtons value that specifies which buttons to display.</param>
    /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
    public static MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButtons buttons)
    {
        return Show(owner, messageBoxText, caption, buttons, MessageBoxImages.None, MessageBoxResult.OK, new MessageBoxOptions());
    }

    /// <summary>
    ///     Displays a message box that has a message and that returns a result of the button the user pressed.
    /// </summary>
    /// <param name="owner">A Window that represents the owner window of the message box.</param>
    /// <param name="messageBoxText">A String that specifies the text to display.</param>
    /// <param name="caption">A String that specifies the title bar caption to display.</param>
    /// <param name="buttons">A MessageBoxButtons value that specifies which buttons to display.</param>
    /// <param name="icon">A MessageBoxImages value that specifies the icon to display.</param>
    /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
    public static MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxImages icon)
    {
        return Show(owner, messageBoxText, caption, buttons, icon, MessageBoxResult.OK, new MessageBoxOptions());
    }

    /// <summary>
    ///     Displays a message box that has a message and that returns a result of the button the user pressed.
    /// </summary>
    /// <param name="owner">A Window that represents the owner window of the message box.</param>
    /// <param name="messageBoxText">A String that specifies the text to display.</param>
    /// <param name="caption">A String that specifies the title bar caption to display.</param>
    /// <param name="buttons">A MessageBoxButtons value that specifies which buttons to display.</param>
    /// <param name="icon">A MessageBoxImages value that specifies the icon to display.</param>
    /// <param name="defaultButton">A MessageBoxResult value that specifies the default result of the message box.</param>
    /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
    public static MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxImages icon, MessageBoxResult defaultButton)
    {
        return Show(owner, messageBoxText, caption, buttons, icon, defaultButton, new MessageBoxOptions());
    }

    /// <summary>
    ///     Displays a message box that has a message and that returns a result of the button the user pressed.
    /// </summary>
    /// <param name="messageBoxText">A String that specifies the text to display.</param>
    /// <param name="options">A MessageBoxOptions value object that specifies the options.</param>
    /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
    public static MessageBoxResult Show(string messageBoxText, MessageBoxOptions options)
    {
        return Show(null, messageBoxText, string.Empty, MessageBoxButtons.OK, MessageBoxImages.None, MessageBoxResult.OK, options);
    }

    /// <summary>
    ///     Displays a message box that has a message and that returns a result of the button the user pressed.
    /// </summary>
    /// <param name="messageBoxText">A String that specifies the text to display.</param>
    /// <param name="caption">A String that specifies the title bar caption to display.</param>
    /// <param name="options">A MessageBoxOptions value object that specifies the options.</param>
    /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
    public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxOptions options)
    {
        return Show(null, messageBoxText, caption, MessageBoxButtons.OK, MessageBoxImages.None, MessageBoxResult.OK, options);
    }

    /// <summary>
    ///     Displays a message box that has a message and that returns a result of the button the user pressed.
    /// </summary>
    /// <param name="messageBoxText">A String that specifies the text to display.</param>
    /// <param name="caption">A String that specifies the title bar caption to display.</param>
    /// <param name="buttons">A MessageBoxButtons value that specifies which buttons to display.</param>
    /// <param name="options">A MessageBoxOptions value object that specifies the options.</param>
    /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
    public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxOptions options)
    {
        return Show(null, messageBoxText, caption, buttons, MessageBoxImages.None, MessageBoxResult.OK, options);
    }

    /// <summary>
    ///     Displays a message box that has a message and that returns a result of the button the user pressed.
    /// </summary>
    /// <param name="messageBoxText">A String that specifies the text to display.</param>
    /// <param name="caption">A String that specifies the title bar caption to display.</param>
    /// <param name="buttons">A MessageBoxButtons value that specifies which buttons to display.</param>
    /// <param name="icon">A MessageBoxImages value that specifies the icon to display.</param>
    /// <param name="options">A MessageBoxOptions value object that specifies the options.</param>
    /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
    public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxImages icon, MessageBoxOptions options)
    {
        return Show(null, messageBoxText, caption, buttons, icon, MessageBoxResult.OK, options);
    }

    /// <summary>
    ///     Displays a message box that has a message and that returns a result of the button the user pressed.
    /// </summary>
    /// <param name="messageBoxText">A String that specifies the text to display.</param>
    /// <param name="caption">A String that specifies the title bar caption to display.</param>
    /// <param name="buttons">A MessageBoxButtons value that specifies which buttons to display.</param>
    /// <param name="icon">A MessageBoxImages value that specifies the icon to display.</param>
    /// <param name="defaultButton">A MessageBoxResult value that specifies the default result of the message box.</param>
    /// <param name="options">A MessageBoxOptions value object that specifies the options.</param>
    /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
    public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxImages icon, MessageBoxResult defaultButton, MessageBoxOptions options)
    {
        return Show(null, messageBoxText, caption, buttons, icon, defaultButton, options);
    }

    /// <summary>
    ///     Displays a message box that has a message and that returns a result of the button the user pressed.
    /// </summary>
    /// <param name="owner">A Window that represents the owner window of the message box.</param>
    /// <param name="messageBoxText">A String that specifies the text to display.</param>
    /// <param name="options">A MessageBoxOptions value object that specifies the options.</param>
    /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
    public static MessageBoxResult Show(Window owner, string messageBoxText, MessageBoxOptions options)
    {
        return Show(owner, messageBoxText, string.Empty, MessageBoxButtons.OK, MessageBoxImages.None, MessageBoxResult.OK, options);
    }

    /// <summary>
    ///     Displays a message box that has a message and that returns a result of the button the user pressed.
    /// </summary>
    /// <param name="owner">A Window that represents the owner window of the message box.</param>
    /// <param name="messageBoxText">A String that specifies the text to display.</param>
    /// <param name="caption">A String that specifies the title bar caption to display.</param>
    /// <param name="options">A MessageBoxOptions value object that specifies the options.</param>
    /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
    public static MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxOptions options)
    {
        return Show(owner, messageBoxText, caption, MessageBoxButtons.OK, MessageBoxImages.None, MessageBoxResult.OK, options);
    }

    /// <summary>
    ///     Displays a message box that has a message and that returns a result of the button the user pressed.
    /// </summary>
    /// <param name="owner">A Window that represents the owner window of the message box.</param>
    /// <param name="messageBoxText">A String that specifies the text to display.</param>
    /// <param name="caption">A String that specifies the title bar caption to display.</param>
    /// <param name="buttons">A MessageBoxButtons value that specifies which buttons to display.</param>
    /// <param name="options">A MessageBoxOptions value object that specifies the options.</param>
    /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
    public static MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxOptions options)
    {
        return Show(owner, messageBoxText, caption, buttons, MessageBoxImages.None, MessageBoxResult.OK, options);
    }

    /// <summary>
    ///     Displays a message box that has a message and that returns a result of the button the user pressed.
    /// </summary>
    /// <param name="owner">A Window that represents the owner window of the message box.</param>
    /// <param name="messageBoxText">A String that specifies the text to display.</param>
    /// <param name="caption">A String that specifies the title bar caption to display.</param>
    /// <param name="buttons">A MessageBoxButtons value that specifies which buttons to display.</param>
    /// <param name="icon">A MessageBoxImages value that specifies the icon to display.</param>
    /// <param name="options">A MessageBoxOptions value object that specifies the options.</param>
    /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
    public static MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxImages icon, MessageBoxOptions options)
    {
        return Show(owner, messageBoxText, caption, buttons, icon, MessageBoxResult.OK, options);
    }

    /// <summary>
    ///     Displays a message box that has a message and that returns a result of the button the user pressed.
    /// </summary>
    /// <param name="owner">A Window that represents the owner window of the message box.</param>
    /// <param name="messageBoxText">A String that specifies the text to display.</param>
    /// <param name="caption">A String that specifies the title bar caption to display.</param>
    /// <param name="buttons">A MessageBoxButtons value that specifies which buttons to display.</param>
    /// <param name="icon">A MessageBoxImages value that specifies the icon to display.</param>
    /// <param name="defaultButton">A MessageBoxResult value that specifies the default result of the message box.</param>
    /// <param name="options">A MessageBoxOptions value object that specifies the options.</param>
    /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
    /// <exception cref="ArgumentNullException">options is null.</exception>
    public static MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxImages icon, MessageBoxResult defaultButton, MessageBoxOptions options)
    {
        if (options == null)
            throw new ArgumentNullException(nameof(options));

        var box = new MessageBoxWindow
        {
            Owner = owner,
            Message = messageBoxText,
            Title = caption ?? string.Empty,
            Buttons = buttons,
            Image = icon,
            DefaultButton = defaultButton,
            Options = options
        };

        box.SetWindowOptions(box, options.WindowOptions);

        var dialogResult = box.ShowDialog();
        if (dialogResult == true)
            return box.Result;

        return buttons == MessageBoxButtons.OK ? MessageBoxResult.OK : MessageBoxResult.Cancel;
    }
}