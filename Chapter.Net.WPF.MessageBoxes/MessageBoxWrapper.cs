// -----------------------------------------------------------------------------------------------------------------
// <copyright file="MessageBoxWrapper.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System.Windows;

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WPF.MessageBoxes
{
    /// <inheritdoc />
    public class MessageBoxWrapper : IMessageBoxWrapper
    {
        /// <inheritdoc />
        public MessageBoxResult Show(string messageBoxText)
        {
            return MessageBox.Show(messageBoxText);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(string messageBoxText, string caption)
        {
            return MessageBox.Show(messageBoxText, caption);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButtons buttons)
        {
            return MessageBox.Show(messageBoxText, caption, buttons);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxImages icon)
        {
            return MessageBox.Show(messageBoxText, caption, buttons, icon);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxImages icon, MessageBoxResult defaultButton)
        {
            return MessageBox.Show(messageBoxText, caption, buttons, icon, defaultButton);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(Window owner, string messageBoxText)
        {
            return MessageBox.Show(owner, messageBoxText);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(Window owner, string messageBoxText, string caption)
        {
            return MessageBox.Show(owner, messageBoxText, caption);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButtons buttons)
        {
            return MessageBox.Show(owner, messageBoxText, caption, buttons);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxImages icon)
        {
            return MessageBox.Show(owner, messageBoxText, caption, buttons, icon);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxImages icon, MessageBoxResult defaultButton)
        {
            return MessageBox.Show(owner, messageBoxText, caption, buttons, icon, defaultButton);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(string messageBoxText, MessageBoxOptions options)
        {
            return MessageBox.Show(messageBoxText, options);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(string messageBoxText, string caption, MessageBoxOptions options)
        {
            return MessageBox.Show(messageBoxText, caption, options);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxOptions options)
        {
            return MessageBox.Show(messageBoxText, caption, buttons, options);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxImages icon, MessageBoxOptions options)
        {
            return MessageBox.Show(messageBoxText, caption, buttons, icon, options);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxImages icon, MessageBoxResult defaultButton, MessageBoxOptions options)
        {
            return MessageBox.Show(messageBoxText, caption, buttons, icon, defaultButton, options);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(Window owner, string messageBoxText, MessageBoxOptions options)
        {
            return MessageBox.Show(owner, messageBoxText, options);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxOptions options)
        {
            return MessageBox.Show(owner, messageBoxText, caption, options);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxOptions options)
        {
            return MessageBox.Show(owner, messageBoxText, caption, buttons, options);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxImages icon, MessageBoxOptions options)
        {
            return MessageBox.Show(owner, messageBoxText, caption, buttons, icon, options);
        }

        /// <inheritdoc />
        public MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButtons buttons, MessageBoxImages icon, MessageBoxResult defaultButton, MessageBoxOptions options)
        {
            return MessageBox.Show(owner, messageBoxText, caption, buttons, icon, defaultButton, options);
        }
    }
}