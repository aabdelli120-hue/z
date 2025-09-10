namespace JamiAlgeria.Models;

/// <summary>
/// Represents a single prayer with its corresponding time string.
/// </summary>
public class PrayerTime
{
    public string Name { get; set; } = string.Empty;
    public string Time { get; set; } = string.Empty;
    /// <summary>
    /// Indicates whether this prayer is the next upcoming prayer.
    /// </summary>
    public bool IsNext { get; set; }
}
