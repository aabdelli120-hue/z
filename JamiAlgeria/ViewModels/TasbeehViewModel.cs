using System.Windows.Input;

namespace JamiAlgeria.ViewModels;

/// <summary>
/// View model backing the tasbeeh counter page.
/// </summary>
public class TasbeehViewModel : BaseViewModel
{
    private int _count;
    public int Count
    {
        get => _count;
        set { _count = value; OnPropertyChanged(); }
    }

    private int _target = 33;
    public int Target
    {
        get => _target;
        set { _target = value; OnPropertyChanged(); }
    }

    public ICommand IncrementCommand { get; }
    public ICommand ResetCommand { get; }

    public TasbeehViewModel()
    {
        IncrementCommand = new Command(() => Count++);
        ResetCommand = new Command(() => Count = 0);
    }
}
