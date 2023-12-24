// -----------------------------------------------------------------------------------------------------------------
// <copyright file="MessageBoxButtonsPanel.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WPF.MessageBoxes;

/// <summary>
///     Represents the buttons panel hosted in the <see cref="MessageBox" />.
/// </summary>
[TemplatePart(Name = "PART_SingleOKButton", Type = typeof(Button))]
[TemplatePart(Name = "PART_OKButton", Type = typeof(Button))]
[TemplatePart(Name = "PART_YesButton", Type = typeof(Button))]
[TemplatePart(Name = "PART_YesToAllButton", Type = typeof(Button))]
[TemplatePart(Name = "PART_NoButton", Type = typeof(Button))]
[TemplatePart(Name = "PART_NoToAllButton", Type = typeof(Button))]
[TemplatePart(Name = "PART_RetryButton", Type = typeof(Button))]
[TemplatePart(Name = "PART_IgnoreButton", Type = typeof(Button))]
[TemplatePart(Name = "PART_CancelButton", Type = typeof(Button))]
[TemplatePart(Name = "PART_AbortButton", Type = typeof(Button))]
[TemplatePart(Name = "PART_HelpButton", Type = typeof(Button))]
[TemplatePart(Name = "PART_TryAgainButton", Type = typeof(Button))]
[TemplatePart(Name = "PART_ContinueButton", Type = typeof(Button))]
[TemplatePart(Name = "PART_DoNotShowAgainCheckBox", Type = typeof(CheckBox))]
[TemplatePart(Name = "PART_DetailsExpander", Type = typeof(Expander))]
public class MessageBoxButtonsPanel : Control
{
    /// <summary>
    ///     Identifies the <see cref="Result" /> dependency property.
    /// </summary>
    public static readonly DependencyProperty ResultProperty =
        DependencyProperty.Register(nameof(Result), typeof(MessageBoxResult), typeof(MessageBoxButtonsPanel), new PropertyMetadata(MessageBoxResult.None));

    /// <summary>
    ///     Identifies the <see cref="Buttons" /> dependency property.
    /// </summary>
    public static readonly DependencyProperty ButtonsProperty =
        DependencyProperty.Register(nameof(Buttons), typeof(MessageBoxButtons), typeof(MessageBoxButtonsPanel), new PropertyMetadata(MessageBoxButtons.OK));

    /// <summary>
    ///     Identifies the <see cref="DefaultButton" /> dependency property.
    /// </summary>
    public static readonly DependencyProperty DefaultButtonProperty =
        DependencyProperty.Register(nameof(DefaultButton), typeof(MessageBoxResult), typeof(MessageBoxButtonsPanel), new PropertyMetadata(MessageBoxResult.None));

    /// <summary>
    ///     Identifies the <see cref="Strings" /> dependency property.
    /// </summary>
    public static readonly DependencyProperty StringsProperty =
        DependencyProperty.Register(nameof(Strings), typeof(MessageBoxStrings), typeof(MessageBoxButtonsPanel), new PropertyMetadata(null));

    /// <summary>
    ///     Identifies the <see cref="ShowHelpButton" /> dependency property.
    /// </summary>
    public static readonly DependencyProperty ShowHelpButtonProperty =
        DependencyProperty.Register(nameof(ShowHelpButton), typeof(bool), typeof(MessageBoxButtonsPanel), new PropertyMetadata(false));

    /// <summary>
    ///     Identifies the <see cref="ShowYesToAllButton" /> dependency property.
    /// </summary>
    public static readonly DependencyProperty ShowYesToAllButtonProperty =
        DependencyProperty.Register(nameof(ShowYesToAllButton), typeof(bool), typeof(MessageBoxButtonsPanel), new PropertyMetadata(false));

    /// <summary>
    ///     Identifies the <see cref="ShowNoToAllButton" /> dependency property.
    /// </summary>
    public static readonly DependencyProperty ShowNoToAllButtonProperty =
        DependencyProperty.Register(nameof(ShowNoToAllButton), typeof(bool), typeof(MessageBoxButtonsPanel), new PropertyMetadata(false));

    /// <summary>
    ///     Identifies the <see cref="ShowDoNotShowAgainCheckBox" /> dependency property.
    /// </summary>
    public static readonly DependencyProperty ShowDoNotShowAgainCheckBoxProperty =
        DependencyProperty.Register(nameof(ShowDoNotShowAgainCheckBox), typeof(bool), typeof(MessageBoxButtonsPanel), new UIPropertyMetadata(false));

    /// <summary>
    ///     Identifies the <see cref="IsDoNotShowAgainChecked" /> dependency property.
    /// </summary>
    public static readonly DependencyProperty IsDoNotShowAgainCheckedProperty =
        DependencyProperty.Register(nameof(IsDoNotShowAgainChecked), typeof(bool), typeof(MessageBoxButtonsPanel), new UIPropertyMetadata(false));

    /// <summary>
    ///     Identifies the <see cref="ShowDetails" /> dependency property.
    /// </summary>
    public static readonly DependencyProperty ShowDetailsProperty =
        DependencyProperty.Register(nameof(ShowDetails), typeof(bool), typeof(MessageBoxButtonsPanel), new UIPropertyMetadata(false));

    /// <summary>
    ///     Identifies the <see cref="Click" /> routed event.
    /// </summary>
    public static readonly RoutedEvent ClickEvent =
        EventManager.RegisterRoutedEvent(nameof(Click), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(MessageBoxButtonsPanel));

    /// <summary>
    ///     Identifies the <see cref="HelpRequest" /> routed event.
    /// </summary>
    public static readonly RoutedEvent HelpRequestEvent =
        EventManager.RegisterRoutedEvent(nameof(HelpRequest), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(MessageBoxButtonsPanel));

    /// <summary>
    ///     Identifies the <see cref="ExpandDetails" /> routed event.
    /// </summary>
    public static readonly RoutedEvent ExpandDetailsEvent =
        EventManager.RegisterRoutedEvent(nameof(ExpandDetails), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(MessageBoxButtonsPanel));

    static MessageBoxButtonsPanel()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(MessageBoxButtonsPanel), new FrameworkPropertyMetadata(typeof(MessageBoxButtonsPanel)));
    }

    /// <summary>
    ///     Gets or sets the result how the user closed the MessageBox.
    /// </summary>
    /// <value>Default: MessageBoxResult.None.</value>
    [DefaultValue(MessageBoxResult.None)]
    public MessageBoxResult Result
    {
        get => (MessageBoxResult)GetValue(ResultProperty);
        set => SetValue(ResultProperty, value);
    }

    /// <summary>
    ///     Gets or sets which buttons has to be shown.
    /// </summary>
    /// <value>Default: MessageBoxButtons.OK.</value>
    [DefaultValue(MessageBoxButtons.OK)]
    public MessageBoxButtons Buttons
    {
        get => (MessageBoxButtons)GetValue(ButtonsProperty);
        set => SetValue(ButtonsProperty, value);
    }

    /// <summary>
    ///     Gets or sets which button is the default button after showing the MessageBox.
    /// </summary>
    /// <value>Default: MessageBoxResult.None.</value>
    [DefaultValue(MessageBoxResult.None)]
    public MessageBoxResult DefaultButton
    {
        get => (MessageBoxResult)GetValue(DefaultButtonProperty);
        set => SetValue(DefaultButtonProperty, value);
    }

    /// <summary>
    ///     Gets or sets all strings to be used in the MessageBox buttons.
    /// </summary>
    /// <value>Default: null.</value>
    [DefaultValue(null)]
    public MessageBoxStrings Strings
    {
        get => (MessageBoxStrings)GetValue(StringsProperty);
        set => SetValue(StringsProperty, value);
    }

    /// <summary>
    ///     Gets or sets a value which indicates if the MessageBox has a help button or not.
    /// </summary>
    /// <value>Default: false.</value>
    [DefaultValue(false)]
    public bool ShowHelpButton
    {
        get => (bool)GetValue(ShowHelpButtonProperty);
        set => SetValue(ShowHelpButtonProperty, value);
    }

    /// <summary>
    ///     Gets or sets a value which indicates if the MessageBox has a 'Yes To All' button.
    /// </summary>
    /// <value>Default: false.</value>
    [DefaultValue(false)]
    public bool ShowYesToAllButton
    {
        get => (bool)GetValue(ShowYesToAllButtonProperty);
        set => SetValue(ShowYesToAllButtonProperty, value);
    }

    /// <summary>
    ///     Gets or sets a value which indicates if the MessageBox has a 'No To All' button.
    /// </summary>
    /// <value>Default: false.</value>
    [DefaultValue(false)]
    public bool ShowNoToAllButton
    {
        get => (bool)GetValue(ShowNoToAllButtonProperty);
        set => SetValue(ShowNoToAllButtonProperty, value);
    }

    /// <summary>
    ///     Gets or sets a value which indicates if the MessageBox has a 'Do Not Show Again' checkbox.
    /// </summary>
    /// <value>Default: false.</value>
    [DefaultValue(false)]
    public bool ShowDoNotShowAgainCheckBox
    {
        get => (bool)GetValue(ShowDoNotShowAgainCheckBoxProperty);
        set => SetValue(ShowDoNotShowAgainCheckBoxProperty, value);
    }

    /// <summary>
    ///     Gets or sets a value which indicates if the 'Do Not Show Again' is checked on start and the check state after close
    ///     the MessageBox.
    /// </summary>
    /// <value>Default: false.</value>
    [DefaultValue(false)]
    public bool IsDoNotShowAgainChecked
    {
        get => (bool)GetValue(IsDoNotShowAgainCheckedProperty);
        set => SetValue(IsDoNotShowAgainCheckedProperty, value);
    }

    /// <summary>
    ///     Gets or sets a value which indicates if the MessageBox has a details button.
    /// </summary>
    /// <value>Default: false.</value>
    [DefaultValue(false)]
    public bool ShowDetails
    {
        get => (bool)GetValue(ShowDetailsProperty);
        set => SetValue(ShowDetailsProperty, value);
    }

    /// <summary>
    ///     The template gets added to the control.
    /// </summary>
    public override void OnApplyTemplate()
    {
        base.OnApplyTemplate();

        AddHandler(ButtonBase.ClickEvent, (RoutedEventHandler)OnMessageBoxButtonClick);
    }

    private void OnMessageBoxButtonClick(object sender, RoutedEventArgs e)
    {
        var button = (ButtonBase)e.OriginalSource;
        switch (button.Name)
        {
            case "PART_SingleOKButton":
                Result = MessageBoxResult.OK;
                break;
            case "PART_OKButton":
                Result = MessageBoxResult.OK;
                break;
            case "PART_YesButton":
                Result = MessageBoxResult.Yes;
                break;
            case "PART_YesToAllButton":
                Result = MessageBoxResult.YesToAll;
                break;
            case "PART_NoButton":
                Result = MessageBoxResult.No;
                break;
            case "PART_NoToAllButton":
                Result = MessageBoxResult.NoToAll;
                break;
            case "PART_RetryButton":
                Result = MessageBoxResult.Retry;
                break;
            case "PART_IgnoreButton":
                Result = MessageBoxResult.Ignore;
                break;
            case "PART_CancelButton":
                Result = MessageBoxResult.Cancel;
                break;
            case "PART_AbortButton":
                Result = MessageBoxResult.Abort;
                break;
            case "PART_TryAgainButton":
                Result = MessageBoxResult.Retry;
                break;
            case "PART_ContinueButton":
                Result = MessageBoxResult.Continue;
                break;
            case "PART_HelpButton":
                OnHelpRequest();
                return;
            case "HeaderSite": // Details expander
                OnExpandDetails();
                return;
            default:
                return;
        }

        OnClick();
    }

    internal void SetDefaultButton()
    {
        switch (DefaultButton)
        {
            case MessageBoxResult.Abort:
                SetDefaultButton("PART_AbortButton");
                break;
            case MessageBoxResult.Cancel:
                SetDefaultButton("PART_CancelButton");
                break;
            case MessageBoxResult.Ignore:
                SetDefaultButton("PART_IgnoreButton");
                break;
            case MessageBoxResult.No:
                SetDefaultButton("PART_NoButton");
                break;
            case MessageBoxResult.None:
                CalculateDefaultButton();
                break;
            case MessageBoxResult.Continue:
                SetDefaultButton("PART_ContinueButton");
                break;
            case MessageBoxResult.OK:
                if (Buttons == MessageBoxButtons.OK)
                    SetDefaultButton("PART_SingleOKButton");
                else
                    SetDefaultButton("PART_OKButton");
                break;
            case MessageBoxResult.Retry:
                if (!SetDefaultButton("PART_TryAgainButton"))
                    SetDefaultButton("PART_RetryButton");
                break;
            case MessageBoxResult.Yes:
                SetDefaultButton("PART_YesButton");
                break;
            case MessageBoxResult.YesToAll:
                SetDefaultButton("PART_YesToAllButton");
                break;
            case MessageBoxResult.NoToAll:
                SetDefaultButton("PART_NoToAllButton");
                break;
        }
    }

    private void CalculateDefaultButton()
    {
        switch (Buttons)
        {
            case MessageBoxButtons.OK:
                SetDefaultButton("PART_SingleOKButton");
                break;
            case MessageBoxButtons.OKCancel:
                SetDefaultButton("PART_OKButton");
                break;
            case MessageBoxButtons.RetryCancel:
            case MessageBoxButtons.AbortRetryIgnore:
                SetDefaultButton("PART_RetryButton");
                break;
            case MessageBoxButtons.YesNo:
            case MessageBoxButtons.YesNoCancel:
                SetDefaultButton("PART_YesButton");
                break;
            case MessageBoxButtons.CancelTryAgainContinue:
                SetDefaultButton("PART_TryAgainButton");
                break;
        }
    }

    private bool SetDefaultButton(string elementName)
    {
        if (GetTemplateChild(elementName) is UIElement button && button.Visibility == Visibility.Visible)
        {
            button.Focus();
            Keyboard.Focus(button);
            return true;
        }

        CalculateDefaultButton();
        return false;
    }

    internal void TakeStyles(MessageBoxOptions.StylesContainer styles)
    {
        TryApplyStyle<MessageBoxButton>(styles.ButtonStyle);
        TryApplyStyle<MessageBoxCheckBox>(styles.CheckBoxStyle);
        TryApplyStyle<MessageBoxExpander>(styles.ExpanderStyle);
    }

    private void TryApplyStyle<T>(Style style) where T : FrameworkElement
    {
        if (style == null)
            return;

        var controls = VisualTreeAssist.GetChildren<T>(this);
        foreach (var control in controls)
            control.Style = style;
    }

    /// <summary>
    ///     Occurs when a button got clicked.
    /// </summary>
    public event RoutedEventHandler Click
    {
        add => AddHandler(ClickEvent, value);
        remove => RemoveHandler(ClickEvent, value);
    }

    private void OnClick()
    {
        var newEventArgs = new RoutedEventArgs(ClickEvent);
        RaiseEvent(newEventArgs);
    }

    /// <summary>
    ///     Occurs when the help button got clicked.
    /// </summary>
    public event RoutedEventHandler HelpRequest
    {
        add => AddHandler(HelpRequestEvent, value);
        remove => RemoveHandler(HelpRequestEvent, value);
    }

    private void OnHelpRequest()
    {
        var newEventArgs = new RoutedEventArgs(HelpRequestEvent);
        RaiseEvent(newEventArgs);
    }

    /// <summary>
    ///     Occurs when the details button got clicked.
    /// </summary>
    public event RoutedEventHandler ExpandDetails
    {
        add => AddHandler(ExpandDetailsEvent, value);
        remove => RemoveHandler(ExpandDetailsEvent, value);
    }

    private void OnExpandDetails()
    {
        var newEventArgs = new RoutedEventArgs(ExpandDetailsEvent);
        RaiseEvent(newEventArgs);
    }
}