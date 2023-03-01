using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Navtest.Views;
using Navtest.Views.Log;
using Navtest.Views.Themes;

namespace Navtest;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		

        builder.Services.AddSingleton<AuthPage>();
        builder.Services.AddTransient<PaymentsPage>();
        builder.Services.AddSingleton<ProfilePage>();
        builder.Services.AddTransient<NewPage1>();
        builder.Services.AddTransient<NewPage2>();
        builder.Services.AddTransient<LoginPage>();
		builder.Services.AddSingleton<ThemePage>();
        builder.Services.AddTransient<SettingsPage>();

        return builder.Build();

    }
}

