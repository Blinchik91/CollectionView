namespace Maui_Spaceships.Views;

public partial class ProfilesPage : ContentPage
{
	public ProfilesPage(ProfilesViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
