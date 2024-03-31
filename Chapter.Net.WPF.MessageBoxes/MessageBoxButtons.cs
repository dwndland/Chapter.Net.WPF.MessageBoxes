// -----------------------------------------------------------------------------------------------------------------
// <copyright file="MessageBoxButtons.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WPF.MessageBoxes
{
    /// <summary>
    ///     Defines which buttons to show in the <see cref="MessageBox" />.
    /// </summary>
    public enum MessageBoxButtons
    {
        /// <summary>
        ///     The MessageBox has just the OK button.
        /// </summary>
        OK = 0,

        /// <summary>
        ///     The MessageBox has the OK and Cancel buttons.
        /// </summary>
        OKCancel = 1,

        /// <summary>
        ///     The MessageBox has the Abort, Retry and Ignore buttons.
        /// </summary>
        AbortRetryIgnore = 2,

        /// <summary>
        ///     The MessageBox has the Yes, No and Cancel buttons.
        /// </summary>
        YesNoCancel = 3,

        /// <summary>
        ///     The MessageBox has the Yes and No buttons.
        /// </summary>
        YesNo = 4,

        /// <summary>
        ///     The MessageBox has the Retry and Cancel buttons.
        /// </summary>
        RetryCancel = 5,

        /// <summary>
        ///     The MessageBox has the Cancel, Try Again and Continue buttons.
        /// </summary>
        CancelTryAgainContinue = 6
    }
}