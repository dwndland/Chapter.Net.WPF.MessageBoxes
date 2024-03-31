<img src="https://raw.githubusercontent.com/dwndland/Chapter.Net.WPF.MessageBoxes/master/Icon.png" alt="logo" width="64"/>

# Chapter.Net.WPF.MessageBoxes Library

## Overview
The System.Windows.MessageBox to use within WPF has two big problems. First is that it looks like windows Classic and it lacks a lot of features.
Here the Chapter.Net.WPF.MessageBoxes library steps in. Thats a custom message box made out of a WPF window. It has a lot of additonal features, see below, and it brings build in styles and allows custom styling.

## Preview
(Some button labels are n German because the screenshots are made on a German windows)
* Example 1  
![Light](https://raw.githubusercontent.com/dwndland/Chapter.Net.WPF.MessageBoxes/master/Images/1_Light.png) ![Dark](https://raw.githubusercontent.com/dwndland/Chapter.Net.WPF.MessageBoxes/master/Images/1_Dark.png) ![Unstyled](https://raw.githubusercontent.com/dwndland/Chapter.Net.WPF.MessageBoxes/master/Images/1_Native.png)
* Example 2  
![Light](https://raw.githubusercontent.com/dwndland/Chapter.Net.WPF.MessageBoxes/master/Images/2_Light.png) ![Dark](https://raw.githubusercontent.com/dwndland/Chapter.Net.WPF.MessageBoxes/master/Images/2_Dark.png) ![Unstyled](https://raw.githubusercontent.com/dwndland/Chapter.Net.WPF.MessageBoxes/master/Images/2_Native.png)
* Example 3  
![Light](https://raw.githubusercontent.com/dwndland/Chapter.Net.WPF.MessageBoxes/master/Images/3_Light.png) ![Dark](https://raw.githubusercontent.com/dwndland/Chapter.Net.WPF.MessageBoxes/master/Images/3_Dark.png) ![Unstyled](https://raw.githubusercontent.com/dwndland/Chapter.Net.WPF.MessageBoxes/master/Images/3_Native.png)
* Example 4  
![Light](https://raw.githubusercontent.com/dwndland/Chapter.Net.WPF.MessageBoxes/master/Images/4_Light.png) ![Dark](https://raw.githubusercontent.com/dwndland/Chapter.Net.WPF.MessageBoxes/master/Images/4_Dark.png) ![Unstyled](https://raw.githubusercontent.com/dwndland/Chapter.Net.WPF.MessageBoxes/master/Images/4_Native.png)
* Example 5  
![Light](https://raw.githubusercontent.com/dwndland/Chapter.Net.WPF.MessageBoxes/master/Images/5_Light.png) ![Dark](https://raw.githubusercontent.com/dwndland/Chapter.Net.WPF.MessageBoxes/master/Images/5_Dark.png) ![Unstyled](https://raw.githubusercontent.com/dwndland/Chapter.Net.WPF.MessageBoxes/master/Images/5_Native.png)
* Example 6  
![Light](https://raw.githubusercontent.com/dwndland/Chapter.Net.WPF.MessageBoxes/master/Images/6_Light.png) ![Dark](https://raw.githubusercontent.com/dwndland/Chapter.Net.WPF.MessageBoxes/master/Images/6_Dark.png) ![Unstyled](https://raw.githubusercontent.com/dwndland/Chapter.Net.WPF.MessageBoxes/master/Images/6_Native.png)

## Features
- **Styling:** Build in Light and Dark style and allow passing custom styles.
- **Window Settings:** Settings like show in task bar, minimum and maximum sizes, resize modes and more.
- **Additional Buttons:** Buttons like Yes To All, Try Again and some more.
- **Do not show again checkbox:** Checkbox shown on the bottom left for configure a do not show again.
- **Details:** Allow expanding and collapsing an area to display details.
- **Clipboard:** Like the original, pressing CTRL+C copies all shown in the message box to the clipboard. That contains the optional details section.
- **Localization:** All buttons shown can be localized manually. Those who are available by windows are also auto translated if needed.

## Getting Started

1. **Installation:**
    - Install the Chapter.Net.WPF.MessageBoxes library via NuGet Package Manager:
    ```bash
    dotnet add package Chapter.Net.WPF.MessageBoxes
    ```

2. **Usage:**
    - Simply use the Chapter.WPF.MessageBox like you would use the build in.
    ```csharp
    var result = MessageBox.Show(ownerWindow, "Message", "Caption", MessageBoxButtons.YesNo);
    if (result == MessageBoxResult.Yes)
    {
    }
    ```

3. **Styling:**
    - With build in dark style
    ```csharp
    var options = new MessageBoxOptions();
    options.WindowOptions.Theme = WindowTheme.Dark; // The window title bar
    options.Styles.Theme = WindowTheme.Dark; // The controls
    
    MessageBox.Show(this, "Message", "Caption", options);
    ```
    - With custom styles
    ```csharp
    var options = new MessageBoxOptions();
    options.WindowOptions.Theme = WindowTheme.Dark; // The window title bar
    options.Styles.ButtonStyle = myButtonStyle;
    
    MessageBox.Show(this, "Message", "Caption", options);
    ```

4. **Localization:**
    - Translate yes and no buttons
    ```csharp
    var options = new MessageBoxOptions();
    options.Strings.Yes = "Yay";
    options.Strings.No = "Nay";
    
    MessageBox.Show(this, "Message", "Caption", options);
    ```

5. **Details:**
    - Show call stack in details pane
    ```csharp
    var options = new MessageBoxOptions();
    options.ShowDetails = true;
    options.DetailsText = Environment.StackTrace;
    
    MessageBox.Show(this, "See Details", "Error", options);
    ```

6. **Do not show again:**
    - Add the checkbox and save it accordingly
    ```csharp
    var options = new MessageBoxOptions();
    options.ShowDoNotShowAgainCheckBox = true;
    
    var result = MessageBox.Show(this, "You want to close the application?", "Close", options);
    system.DoNotShowAgain = options.IsDoNotShowAgainChecked;
    ```

## Example
- Save single or all
    ```csharp
    public class MainViewModel
    {
        public void SaveAll()
        {
            var options = new MessageBoxOptions();
            options.ShowYesToAllButton = true;
            var result = MessageBox.Show(this, "Save changed files?", "Save", MessageBoxButtons.YesNo, options);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    SaveCurrentFile();
                    break;
                case MessageBoxResult.YesToAll:
                    SaveAllFiles();
                    break;
                case MessageBoxResult.No:
                    break;
            }
        }
    }
    ```

- Do not show again
    ```csharp
    public class MainViewModel
    {
        public void TryShutdown()
        {
            if (!Settings.DoNotShowAgain)
            {
                var options = new MessageBoxOptions();
                options.ShowDoNotShowAgainCheckBox = true;
    
                var result = MessageBox.Show(this, "You want to close the application?", "Close", options);
                Settings.DoNotShowAgain = options.IsDoNotShowAgainChecked;
                if (result == MessageBoxResult.Yes)
                    Shutdown();
            }
            else
                Shutdown();
        }
    }
    ```

## Links
* [NuGet](https://www.nuget.org/packages/Chapter.Net.WPF.MessageBoxes)
* [GitHub](https://github.com/my-libraries/Chapter.Net.WPF.MessageBoxes)

## License
Copyright (c) David Wendland. All rights reserved.
Licensed under the MIT License. See LICENSE file in the project root for full license information.
