// -----------------------------------------------------------------------------------------------------------------
// <copyright file="MessageBoxImages.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WPF.MessageBoxes
{
    /// <summary>
    ///     Defines which icon to show in the <see cref="MessageBox" />.
    /// </summary>
    public enum MessageBoxImages
    {
        /// <summary>
        ///     The MessageBox has no icon.
        /// </summary>
        None = 0,

        /// <summary>
        ///     The MessageBox has the Error icon.
        /// </summary>
        Error = 16,

        /// <summary>
        ///     The MessageBox has the Hand icon.
        /// </summary>
        Hand = 16,

        /// <summary>
        ///     The MessageBox has the Stop icon.
        /// </summary>
        Stop = 16,

        /// <summary>
        ///     The MessageBox has the Question icon.
        /// </summary>
        Question = 32,

        /// <summary>
        ///     The MessageBox has the Exclamation icon.
        /// </summary>
        Exclamation = 48,

        /// <summary>
        ///     The MessageBox has the Warning icon.
        /// </summary>
        Warning = 48,

        /// <summary>
        ///     The MessageBox has the Information icon.
        /// </summary>
        Information = 64,

        /// <summary>
        ///     The MessageBox has the Asterisk icon.
        /// </summary>
        Asterisk = 64
    }
}