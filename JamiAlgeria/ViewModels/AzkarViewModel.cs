using System.Collections.ObjectModel;
using JamiAlgeria.Models;
using JamiAlgeria.Services;

namespace JamiAlgeria.ViewModels;

/// <summary>
/// View model providing morning and evening azkar collections.
/// </summary>
public class AzkarViewModel : BaseViewModel
{
    private readonly AzkarService _service;

    public ObservableCollection<AzkarItem> Morning { get; } = new();
    public ObservableCollection<AzkarItem> Evening { get; } = new();

    public AzkarViewModel(AzkarService service)
    {
        _service = service;
        Load();
    }

    private void Load()
    {
        foreach (var item in _service.GetMorningAzkar())
            Morning.Add(item);
        foreach (var item in _service.GetEveningAzkar())
            Evening.Add(item);
    }
}
