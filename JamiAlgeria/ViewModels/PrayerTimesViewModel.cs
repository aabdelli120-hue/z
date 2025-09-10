using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using JamiAlgeria.Models;
using JamiAlgeria.Services;

namespace JamiAlgeria.ViewModels;

/// <summary>
/// View model responsible for loading and exposing daily prayer times.
/// </summary>
public class PrayerTimesViewModel : BaseViewModel
{
    private readonly PrayerTimeService _service;

    public ObservableCollection<PrayerTime> Times { get; } = new();

    private PrayerTime? _nextPrayer;
    public PrayerTime? NextPrayer
    {
        get => _nextPrayer;
        set { _nextPrayer = value; OnPropertyChanged(); }
    }

    public ICommand LoadCommand { get; }

    public PrayerTimesViewModel(PrayerTimeService service)
    {
        _service = service;
        LoadCommand = new Command(async () => await LoadAsync());
        // Automatically load on creation
        LoadCommand.Execute(null);
    }

    private async Task LoadAsync()
    {
        Times.Clear();
        var result = await _service.GetTodayPrayerTimesAsync("Algiers", "Algeria");
        foreach (var p in result)
            Times.Add(p);

        NextPrayer = _service.GetNextPrayer(Times);
        if (NextPrayer != null)
            NextPrayer.IsNext = true;
    }
}
