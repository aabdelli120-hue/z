namespace JamiAlgeria.Models;

/// <summary>
/// Represents an individual azkar entry with optional translation.
/// </summary>
public class AzkarItem
{
    public string Text { get; set; } = string.Empty;
    public string? Translation { get; set; }
}
