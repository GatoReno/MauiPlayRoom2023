using Navtest.Views;
using Navtest.Views.Cammera;
using Navtest.Views.Themes;

namespace Navtest;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(AuthPage),typeof(AuthPage));
        Routing.RegisterRoute(nameof(NewPage1), typeof(NewPage1));
        Routing.RegisterRoute(nameof(NewPage2), typeof(NewPage2));
        Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
        Routing.RegisterRoute(nameof(PaymentsPage), typeof(PaymentsPage));
        Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
        
        Routing.RegisterRoute(nameof(ThemePage), typeof(ThemePage));
        Routing.RegisterRoute(nameof(CameraPage), typeof(CameraPage));

    }
}

