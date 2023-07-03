using Maui_Spaceships.Models;
using Maui_Spaceships.Services;

namespace Maui_Spaceships.ViewModels;

public partial class SpaceshipsViewModel : BaseViewModel
{
    public SpaceshipsViewModel(SampleDataService service)
    {
        dataService = service;
    }

    readonly SampleDataService dataService;

    [ObservableProperty]
    bool isRefreshing;

    [ObservableProperty]
    ObservableCollection<SpaceshipItem> items;



    [RelayCommand]
    private async void OnRefreshing()
    {
        IsRefreshing = true;

        try
        {
            await LoadDataAsync();
        }
        finally
        {
            IsRefreshing = false;
        }
    }

    [RelayCommand]
    public async Task LoadMore()
    {
        //Items.Clear();

        //var items = await dataService.GetItems();

        //foreach (var item in items)
        //{
        //    Items.Add(item);
        //}
    }

    public async Task LoadDataAsync()
    {
        Items = new ObservableCollection<SpaceshipItem>(await dataService.GetItems());
    }

    [RelayCommand]
    private async void GoToDetails(SpaceshipItem item)
    {
        //ToDo:
        //await Shell.Current.GoToAsync(nameof(ListDetailDetailPage), true, new Dictionary<string, object>
        //{
        //    { "Item", item }
        //});
    }
}
