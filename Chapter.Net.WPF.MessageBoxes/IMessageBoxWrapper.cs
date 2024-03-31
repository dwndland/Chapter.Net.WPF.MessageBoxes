// -----------------------------------------------------------------------------------------------------------------
// <copyright file="IMessageBoxWrapper.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System;
using System.Windows;

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WPF.MessageBoxes
{
    /// <summary>
    ///     Show a WPF window as a message box which is full configurable.
    /// </summary>
    /// <example>
    ///     <code lang="csharp">
    /// <![CDATA[
    /// public class ViewModel : ObservableObject
    /// {
    ///     private IMessageBoxWrapper _messageBox
    ///     public ViewModel(IMessageBoxWrapper messageBox)
    ///     {
    ///         _messageBox = messageBox;
    ///     }
    /// 
    ///     public void Show()
    ///     {
    ///         messageBox.Show("Messagebox Text");
    ///     }
    /// }
    ///
    /// [TestFixture]
    /// public class ViewModelTests
    /// {
    ///     private Mock<IMessageBoxWrapper> _messageBox;
    ///     private ViewModel _target;
    ///
    ///     [SetUp]
    ///     public void Setup()
    ///     {
    ///         _messageBox = new Mock<IMessageBoxWrapper>();
    ///         _target = new ViewModel(_messageBox.Object);
    ///     }
    ///
    ///     [Test]
    ///     public void Show_Called_ShowsMessageBox()
    ///     {
    ///         _target.Show();
    ///
    ///         _messageBox.Verify(x => x.Show("Messagebox Text"), Times.Once);
    ///     }
    /// }
    /// ]]>
    /// </code>
    /// </example>
    public interface IMessageBoxWrapper
    {
        /// <summary>
        ///     Displays a message box that has a message and that returns a result of the button the user pressed.
        /// </summary>
        /// <param name="messageBoxText">A String that specifies the text to display.</param>
        /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        MessageBoxResult Show(string messageBoxText);

        /// <summary>
        ///     Displays a message box that has a message and that returns a result of the button the user pressed.
        /// </summary>
        /// <param name="messageBoxText">A String that specifies the text to display.</param>
        /// <param name="caption">A String that specifies the title bar caption to display.</param>
        /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        MessageBoxResult Show(string messageBoxText, string caption);

        /// <summary>
        ///     Displays a message box that has a message and that returns a result of the button the user pressed.
        /// </summary>
        /// <param name="messageBoxText">A String that specifies the text to display.</param>
        /// <param name="caption">A String that specifies the title bar caption to display.</param>
        /// <param name="buttons">A MessageBoxButtons value that specifies which buttons to display.</param>
        /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButtons buttons);

        /// <summary>
        ///     Displays a message box that has a message and that returns a result of the button the user pressed.
        /// </summary>
        /// <param name="messageBoxText">A String that specifies the text to display.</param>
        /// <param name="caption">A String that specifies the title bar caption to display.</param>
        /// <param name="buttons">A MessageBoxButtons value that specifies which buttons to display.</param>
        /// <param name="icon">A MessageBoxImages value that specifies the icon to display.</param>
        /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxImages icon);

        /// <summary>
        ///     Displays a message box that has a message and that returns a result of the button the user pressed.
        /// </summary>
        /// <param name="messageBoxText">A String that specifies the text to display.</param>
        /// <param name="caption">A String that specifies the title bar caption to display.</param>
        /// <param name="buttons">A MessageBoxButtons value that specifies which buttons to display.</param>
        /// <param name="icon">A MessageBoxImages value that specifies the icon to display.</param>
        /// <param name="defaultButton">A MessageBoxResult value that specifies the default result of the message box.</param>
        /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxImages icon, MessageBoxResult defaultButton);

        /// <summary>
        ///     Displays a message box that has a message and that returns a result of the button the user pressed.
        /// </summary>
        /// <param name="owner">A Window that represents the owner window of the message box.</param>
        /// <param name="messageBoxText">A String that specifies the text to display.</param>
        /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        MessageBoxResult Show(Window owner, string messageBoxText);

        /// <summary>
        ///     Displays a message box that has a message and that returns a result of the button the user pressed.
        /// </summary>
        /// <param name="owner">A Window that represents the owner window of the message box.</param>
        /// <param name="messageBoxText">A String that specifies the text to display.</param>
        /// <param name="caption">A String that specifies the title bar caption to display.</param>
        /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        MessageBoxResult Show(Window owner, string messageBoxText, string caption);

        /// <summary>
        ///     Displays a message box that has a message and that returns a result of the button the user pressed.
        /// </summary>
        /// <param name="owner">A Window that represents the owner window of the message box.</param>
        /// <param name="messageBoxText">A String that specifies the text to display.</param>
        /// <param name="caption">A String that specifies the title bar caption to display.</param>
        /// <param name="buttons">A MessageBoxButtons value that specifies which buttons to display.</param>
        /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButtons buttons);

        /// <summary>
        ///     Displays a message box that has a message and that returns a result of the button the user pressed.
        /// </summary>
        /// <param name="owner">A Window that represents the owner window of the message box.</param>
        /// <param name="messageBoxText">A String that specifies the text to display.</param>
        /// <param name="caption">A String that specifies the title bar caption to display.</param>
        /// <param name="buttons">A MessageBoxButtons value that specifies which buttons to display.</param>
        /// <param name="icon">A MessageBoxImages value that specifies the icon to display.</param>
        /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxImages icon);

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
        MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxImages icon, MessageBoxResult defaultButton);

        /// <summary>
        ///     Displays a message box that has a message and that returns a result of the button the user pressed.
        /// </summary>
        /// <param name="messageBoxText">A String that specifies the text to display.</param>
        /// <param name="options">A MessageBoxOptions value object that specifies the options.</param>
        /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        MessageBoxResult Show(string messageBoxText, MessageBoxOptions options);

        /// <summary>
        ///     Displays a message box that has a message and that returns a result of the button the user pressed.
        /// </summary>
        /// <param name="messageBoxText">A String that specifies the text to display.</param>
        /// <param name="caption">A String that specifies the title bar caption to display.</param>
        /// <param name="options">A MessageBoxOptions value object that specifies the options.</param>
        /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        MessageBoxResult Show(string messageBoxText, string caption, MessageBoxOptions options);

        /// <summary>
        ///     Displays a message box that has a message and that returns a result of the button the user pressed.
        /// </summary>
        /// <param name="messageBoxText">A String that specifies the text to display.</param>
        /// <param name="caption">A String that specifies the title bar caption to display.</param>
        /// <param name="buttons">A MessageBoxButtons value that specifies which buttons to display.</param>
        /// <param name="options">A MessageBoxOptions value object that specifies the options.</param>
        /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxOptions options);

        /// <summary>
        ///     Displays a message box that has a message and that returns a result of the button the user pressed.
        /// </summary>
        /// <param name="messageBoxText">A String that specifies the text to display.</param>
        /// <param name="caption">A String that specifies the title bar caption to display.</param>
        /// <param name="buttons">A MessageBoxButtons value that specifies which buttons to display.</param>
        /// <param name="icon">A MessageBoxImages value that specifies the icon to display.</param>
        /// <param name="options">A MessageBoxOptions value object that specifies the options.</param>
        /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxImages icon, MessageBoxOptions options);

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
        MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxImages icon, MessageBoxResult defaultButton, MessageBoxOptions options);

        /// <summary>
        ///     Displays a message box that has a message and that returns a result of the button the user pressed.
        /// </summary>
        /// <param name="owner">A Window that represents the owner window of the message box.</param>
        /// <param name="messageBoxText">A String that specifies the text to display.</param>
        /// <param name="options">A MessageBoxOptions value object that specifies the options.</param>
        /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        MessageBoxResult Show(Window owner, string messageBoxText, MessageBoxOptions options);

        /// <summary>
        ///     Displays a message box that has a message and that returns a result of the button the user pressed.
        /// </summary>
        /// <param name="owner">A Window that represents the owner window of the message box.</param>
        /// <param name="messageBoxText">A String that specifies the text to display.</param>
        /// <param name="caption">A String that specifies the title bar caption to display.</param>
        /// <param name="options">A MessageBoxOptions value object that specifies the options.</param>
        /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxOptions options);

        /// <summary>
        ///     Displays a message box that has a message and that returns a result of the button the user pressed.
        /// </summary>
        /// <param name="owner">A Window that represents the owner window of the message box.</param>
        /// <param name="messageBoxText">A String that specifies the text to display.</param>
        /// <param name="caption">A String that specifies the title bar caption to display.</param>
        /// <param name="buttons">A MessageBoxButtons value that specifies which buttons to display.</param>
        /// <param name="options">A MessageBoxOptions value object that specifies the options.</param>
        /// <returns>A MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxOptions options);

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
        MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxImages icon, MessageBoxOptions options);

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
        MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxImages icon, MessageBoxResult defaultButton, MessageBoxOptions options);
    }
}