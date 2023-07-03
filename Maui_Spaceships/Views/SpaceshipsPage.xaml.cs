namespace Maui_Spaceships.Views;

public partial class SpaceshipsPage : ContentPage
{
    SpaceshipsViewModel ViewModel;

    public SpaceshipsPage(SpaceshipsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = ViewModel = viewModel;
	}

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        await ViewModel.LoadDataAsync();
    }
}
