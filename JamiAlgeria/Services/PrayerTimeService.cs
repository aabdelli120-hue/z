using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using JamiAlgeria.Models;

namespace JamiAlgeria.Services;

/// <summary>
/// Service responsible for retrieving prayer times using the Aladhan API.
/// </summary>
public class PrayerTimeService
{
    private readonly HttpClient _httpClient = new();

    public async Task<IEnumerable<PrayerTime>> GetTodayPrayerTimesAsync(string city, string country)
    {
        var url = $"https://api.aladhan.com/v1/timingsByCity?city={city}&country={country}&method=2";
        var response = await _httpClient.GetFromJsonAsync<AladhanResponse>(url);
        var list = new List<PrayerTime>();

        if (response?.data?.timings != null)
        {
            foreach (var kv in response.data.timings)
                list.Add(new PrayerTime { Name = kv.Key, Time = kv.Value });
        }

        return list;
    }

    /// <summary>
    /// Determines the next upcoming prayer time from a collection.
    /// </summary>
    public PrayerTime? GetNextPrayer(IEnumerable<PrayerTime> times)
    {
        var now = DateTime.Now;
        foreach (var pt in times)
        {
            if (DateTime.TryParseExact(pt.Time, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out var parsed))
            {
                if (parsed.TimeOfDay > now.TimeOfDay)
                    return pt;
            }
        }

        return null;
    }

    // Internal classes for deserialization of Aladhan API response
    private class AladhanResponse
    {
        public Data? data { get; set; }
    }

    private class Data
    {
        public Dictionary<string, string>? timings { get; set; }
    }
}
