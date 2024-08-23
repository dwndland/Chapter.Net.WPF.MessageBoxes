// -----------------------------------------------------------------------------------------------------------------
// <copyright file="MessageBoxStrings.cs" company="dwndland">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WPF.MessageBoxes;

/// <summary>
///     Provides message box element strings in the current system language.
/// </summary>
public class MessageBoxStrings
{
    private const int YesToAllId = -800;
    private const int NoToAllId = -801;
    private const int DoNotShowAgainId = -802;
    private const int OpenDetailsId = -803;
    private const int CloseDetailsId = -804;
    private string _abort;
    private string _cancel;
    private string _closeDetails;
    private string _continue;
    private string _doNotShowAgain;
    private string _help;
    private string _ignore;
    private string _no;
    private string _noToAll;
    private string _ok;
    private string _openDetails;
    private string _retry;
    private string _tryAgain;
    private string _yes;
    private string _yesToAll;

    /// <summary>
    ///     Gets or sets the translation for 'OK'.
    /// </summary>
    public string OK
    {
        get => Load(SystemTexts.OK_CAPTION, _ok);
        set => _ok = value;
    }

    /// <summary>
    ///     Gets or sets the translation for 'Cancel'.
    /// </summary>
    public string Cancel
    {
        get => Load(SystemTexts.CANCEL_CAPTION, _cancel);
        set => _cancel = value;
    }

    /// <summary>
    ///     Gets or sets the translation for 'Abort'.
    /// </summary>
    public string Abort
    {
        get => Load(SystemTexts.ABORT_CAPTION, _abort);
        set => _abort = value;
    }

    /// <summary>
    ///     Gets or sets the translation for 'Retry'.
    /// </summary>
    public string Retry
    {
        get => Load(SystemTexts.RETRY_CAPTION, _retry);
        set => _retry = value;
    }

    /// <summary>
    ///     Gets or sets the translation for 'Ignore'.
    /// </summary>
    public string Ignore
    {
        get => Load(SystemTexts.IGNORE_CAPTION, _ignore);
        set => _ignore = value;
    }

    /// <summary>
    ///     Gets or sets the translation for 'Yes'.
    /// </summary>
    public string Yes
    {
        get => Load(SystemTexts.YES_CAPTION, _yes);
        set => _yes = value;
    }

    /// <summary>
    ///     Gets or sets the translation for 'No'.
    /// </summary>
    public string No
    {
        get => Load(SystemTexts.NO_CAPTION, _no);
        set => _no = value;
    }

    /// <summary>
    ///     Gets or sets the translation for 'Help'.
    /// </summary>
    public string Help
    {
        get => Load(SystemTexts.HELP_CAPTION, _help);
        set => _help = value;
    }

    /// <summary>
    ///     Gets or sets the translation for 'Try Again'.
    /// </summary>
    public string TryAgain
    {
        get => Load(SystemTexts.TRYAGAIN_CAPTION, _tryAgain);
        set => _tryAgain = value;
    }

    /// <summary>
    ///     Gets or sets the translation for 'Continue'.
    /// </summary>
    public string Continue
    {
        get => Load(SystemTexts.CONTINUE_CAPTION, _continue);
        set => _continue = value;
    }

    /// <summary>
    ///     Gets or sets the translation for 'Yes To All'.
    /// </summary>
    public string YesToAll
    {
        get => LoadCustom(YesToAllId, _yesToAll);
        set => _yesToAll = value;
    }

    /// <summary>
    ///     Gets or sets the translation for 'No To All'.
    /// </summary>
    public string NoToAll
    {
        get => LoadCustom(NoToAllId, _noToAll);
        set => _noToAll = value;
    }

    /// <summary>
    ///     Gets or sets the translation for 'Do Not Show Again'.
    /// </summary>
    public string DoNotShowAgain
    {
        get => LoadCustom(DoNotShowAgainId, _doNotShowAgain);
        set => _doNotShowAgain = value;
    }

    /// <summary>
    ///     Gets or sets the translation for 'Open Details'.
    /// </summary>
    public string OpenDetails
    {
        get => LoadCustom(OpenDetailsId, _openDetails);
        set => _openDetails = value;
    }

    /// <summary>
    ///     Gets or sets the translation for 'Close Details'.
    /// </summary>
    public string CloseDetails
    {
        get => LoadCustom(CloseDetailsId, _closeDetails);
        set => _closeDetails = value;
    }

    private string Load(uint id, string alternate)
    {
        if (!string.IsNullOrWhiteSpace(alternate))
            return alternate;
        var systemString = SystemTexts.GetString(id);
        return systemString.Replace('&', '_');
    }

    private string LoadCustom(int id, string alternate)
    {
        if (!string.IsNullOrWhiteSpace(alternate))
            return alternate;

        switch (id)
        {
            case YesToAllId:
                return "Y_es to All";
            case NoToAllId:
                return "N_o to All";
            case DoNotShowAgainId:
                return "_Don't show this message again";
            case OpenDetailsId:
                return "_Show Details";
            case CloseDetailsId:
                return "_Hide Details";
            default:
                return string.Empty;
        }
    }
}