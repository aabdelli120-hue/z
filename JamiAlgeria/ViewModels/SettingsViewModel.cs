using System.Collections.Generic;
using System.Windows.Input;

namespace JamiAlgeria.ViewModels;

/// <summary>
/// View model for the settings page allowing language and notification selection.
/// </summary>
public class SettingsViewModel : BaseViewModel
{
    private readonly TasbeehViewModel _tasbeehViewModel;

    public IList<string> Languages { get; } = new List<string> { "ar", "fr", "en" };
    public IList<string> NotificationStyles { get; } = new List<string> { "Adhan", "Beep", "Silent" };

    private string _selectedLanguage = "ar";
    public string SelectedLanguage
    {
        get => _selectedLanguage;
        set { _selectedLanguage = value; OnPropertyChanged(); }
    }

    private string _selectedNotification = "Adhan";
    public string SelectedNotification
    {
        get => _selectedNotification;
        set { _selectedNotification = value; OnPropertyChanged(); }
    }

    public ICommand ResetTasbeehCommand { get; }

    public SettingsViewModel(TasbeehViewModel tasbeehViewModel)
    {
        _tasbeehViewModel = tasbeehViewModel;
        ResetTasbeehCommand = new Command(() => _tasbeehViewModel.Count = 0);
    }
}
