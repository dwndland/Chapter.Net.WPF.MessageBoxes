// -----------------------------------------------------------------------------------------------------------------
// <copyright file="IMessageCopyFormatter.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WPF.MessageBoxes
{
    /// <summary>
    ///     Represents the formatter to be used after pressing Ctrl+C with the <see cref="MessageBox" /> open.
    /// </summary>
    public interface IMessageCopyFormatter
    {
        /// <summary>
        ///     Called to copy the MessageBox content somewhere to.
        /// </summary>
        /// <param name="title">The MessageBox title.</param>
        /// <param name="message">The message shown in the MessageBox.</param>
        /// <param name="details">The details if available.</param>
        /// <param name="buttons">The buttons available in the MessageBox.</param>
        /// <param name="icon">The icon shown in the MessageBox.</param>
        /// <param name="strings">The strings used in the MessageBox.</param>
        void Copy(string title, string message, string details, MessageBoxButtons buttons, MessageBoxImages icon, MessageBoxStrings strings);
    }
}