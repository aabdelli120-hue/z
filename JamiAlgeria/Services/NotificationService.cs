using System;
using System.Threading.Tasks;

namespace JamiAlgeria.Services;

/// <summary>
/// Placeholder service for scheduling notifications. Platform specific implementations
/// can be added later for Android, iOS and Windows.
/// </summary>
public class NotificationService
{
    public Task ScheduleNotificationAsync(string title, string message, DateTime time)
    {
        // TODO: Integrate platform specific notification logic
        return Task.CompletedTask;
    }
}
