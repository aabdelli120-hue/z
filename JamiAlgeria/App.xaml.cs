using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace JamiAlgeria;

/// <summary>
///     Application entry point. Sets the main page to the application shell
///     which handles navigation through the tab bar.
/// </summary>
public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        // Use Shell for navigation and tab bar
        MainPage = new AppShell();
    }
}
