// -----------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultMessageCopyFormatter.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System.Text;
using System.Windows;

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WPF.MessageBoxes;

/// <summary>
///     Takes all data from the <see cref="MessageBox" /> after user pressed Ctrl+C and copy its information to the
///     clipboard.
/// </summary>
public sealed class DefaultMessageCopyFormatter : IMessageCopyFormatter
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
    public void Copy(string title, string message, string details, MessageBoxButtons buttons, MessageBoxImages icon, MessageBoxStrings strings)
    {
        var builder = new StringBuilder();
        builder.AppendLine("---------------------------");
        builder.AppendLine(title);
        builder.AppendLine("---------------------------");
        builder.AppendLine(message);
        builder.AppendLine("---------------------------");
        AppendButtons(builder, buttons, strings);
        builder.AppendLine("---------------------------");
        if (!string.IsNullOrWhiteSpace(details))
        {
            builder.AppendLine(details);
            builder.AppendLine("---------------------------");
        }

        Clipboard.SetText(builder.ToString());
    }

    private void AppendButtons(StringBuilder builder, MessageBoxButtons buttons, MessageBoxStrings strings)
    {
        switch (buttons)
        {
            case MessageBoxButtons.OK:
                builder.AppendLine($"{GetString(strings.OK)}   ");
                break;
            case MessageBoxButtons.OKCancel:
                builder.AppendLine($"{GetString(strings.OK)}   {GetString(strings.Cancel)}   ");
                break;
            case MessageBoxButtons.RetryCancel:
                builder.AppendLine($"{GetString(strings.Retry)}   {GetString(strings.Cancel)}   ");
                break;
            case MessageBoxButtons.YesNo:
                builder.AppendLine($"{GetString(strings.Yes)}   {GetString(strings.No)}   ");
                break;
            case MessageBoxButtons.YesNoCancel:
                builder.AppendLine($"{GetString(strings.Yes)}   {GetString(strings.No)}   {GetString(strings.Cancel)}   ");
                break;
            case MessageBoxButtons.AbortRetryIgnore:
                builder.AppendLine($"{GetString(strings.Abort)}   {GetString(strings.Retry)}   {GetString(strings.Ignore)}   ");
                break;
        }
    }

    private string GetString(string original)
    {
        return original.Replace("_", "");
    }
}