using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace JamiAlgeria.ViewModels;

/// <summary>
/// Base class that implements <see cref="INotifyPropertyChanged"/> to support data binding.
/// </summary>
public class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
