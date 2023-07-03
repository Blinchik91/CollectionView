using Maui_Spaceships.Services;

namespace Maui_Spaceships;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>();

        // Views & ViewModels
		builder.Services.AddSingleton<SpaceshipsViewModel>();
		builder.Services.AddSingleton<SpaceshipsPage>();

		builder.Services.AddSingleton<ProfilesViewModel>();
		builder.Services.AddSingleton<ProfilesPage>();

        // Services
        builder.Services.AddTransient<SampleDataService>();

        return builder.Build();
	}
}
