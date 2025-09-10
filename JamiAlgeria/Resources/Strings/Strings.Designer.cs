using System.Globalization;
using System.Reflection;
using System.Resources;

namespace JamiAlgeria.Resources.Strings;

/// <summary>
///     Strongly typed resource accessor for localized strings.
/// </summary>
public static class Strings
{
    private static readonly ResourceManager ResourceManager =
        new ResourceManager("JamiAlgeria.Resources.Strings.Strings", typeof(Strings).GetTypeInfo().Assembly);

    public static string Home => ResourceManager.GetString("Home", CultureInfo.CurrentUICulture) ?? "Home";
    public static string PrayerTimes => ResourceManager.GetString("PrayerTimes", CultureInfo.CurrentUICulture) ?? "Prayer Times";
    public static string Azkar => ResourceManager.GetString("Azkar", CultureInfo.CurrentUICulture) ?? "Azkar";
    public static string Tasbeeh => ResourceManager.GetString("Tasbeeh", CultureInfo.CurrentUICulture) ?? "Tasbeeh";
    public static string Settings => ResourceManager.GetString("Settings", CultureInfo.CurrentUICulture) ?? "Settings";
    public static string MorningAzkar => ResourceManager.GetString("MorningAzkar", CultureInfo.CurrentUICulture) ?? "Morning Azkar";
    public static string EveningAzkar => ResourceManager.GetString("EveningAzkar", CultureInfo.CurrentUICulture) ?? "Evening Azkar";
    public static string Increment => ResourceManager.GetString("Increment", CultureInfo.CurrentUICulture) ?? "Increment";
    public static string Reset => ResourceManager.GetString("Reset", CultureInfo.CurrentUICulture) ?? "Reset";
    public static string Language => ResourceManager.GetString("Language", CultureInfo.CurrentUICulture) ?? "Language";
    public static string NotificationStyle => ResourceManager.GetString("NotificationStyle", CultureInfo.CurrentUICulture) ?? "Notification Style";
    public static string ResetTasbeeh => ResourceManager.GetString("ResetTasbeeh", CultureInfo.CurrentUICulture) ?? "Reset Tasbeeh";
    public static string Welcome => ResourceManager.GetString("Welcome", CultureInfo.CurrentUICulture) ?? "Welcome";
}
