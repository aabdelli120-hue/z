using System.Collections.Generic;
using JamiAlgeria.Models;

namespace JamiAlgeria.Services;

/// <summary>
/// Provides static collections of azkar for morning and evening.
/// </summary>
public class AzkarService
{
    public IEnumerable<AzkarItem> GetMorningAzkar() => new[]
    {
        new AzkarItem { Text = "سبحان الله وبحمده", Translation = "Glory be to Allah and praise be to Him" },
        new AzkarItem { Text = "لا إله إلا الله وحده لا شريك له", Translation = "There is no deity except Allah, alone with no partner" }
    };

    public IEnumerable<AzkarItem> GetEveningAzkar() => new[]
    {
        new AzkarItem { Text = "أستغفر الله العظيم", Translation = "I seek forgiveness from Allah the Almighty" },
        new AzkarItem { Text = "اللهم صل وسلم على نبينا محمد", Translation = "O Allah, send peace and blessings upon our Prophet Muhammad" }
    };
}
