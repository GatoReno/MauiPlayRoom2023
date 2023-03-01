using Navtest.Views;

namespace Navtest;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		var log = false;
		if (log)
		{
            MainPage = new NavigationPage(new AuthPage());
        }
		else
		{
            MainPage = new AppShell();
        }
		
	}

	
}

