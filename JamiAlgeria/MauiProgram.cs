using CommunityToolkit.Maui;
using Microsoft.Maui;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using Microsoft.Extensions.Logging;

namespace JamiAlgeria;

/// <summary>
///     Configures the MAUI application, registering services, view models, and pages.
/// </summary>
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // Services
        builder.Services.AddSingleton<Services.PrayerTimeService>();
        builder.Services.AddSingleton<Services.AzkarService>();
        builder.Services.AddSingleton<Services.NotificationService>();

        // ViewModels
        builder.Services.AddSingleton<ViewModels.PrayerTimesViewModel>();
        builder.Services.AddSingleton<ViewModels.AzkarViewModel>();
        builder.Services.AddSingleton<ViewModels.TasbeehViewModel>();
        builder.Services.AddSingleton<ViewModels.SettingsViewModel>();

        // Pages
        builder.Services.AddSingleton<Views.MainPage>();
        builder.Services.AddSingleton<Views.PrayerTimesPage>();
        builder.Services.AddSingleton<Views.AzkarPage>();
        builder.Services.AddSingleton<Views.TasbeehPage>();
        builder.Services.AddSingleton<Views.SettingsPage>();

        #if DEBUG
        builder.Logging.AddDebug();
        #endif

        return builder.Build();
    }
}
