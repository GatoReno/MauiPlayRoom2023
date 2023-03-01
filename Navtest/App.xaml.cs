 using Navtest.Views;

namespace Navtest;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        MainPage = new AppShell();


    }

    protected  async  override void OnStart()
    {
        base.OnStart();
        var log = false;
        if (log)
        {
            MainPage = new AppShell();
        }
        else
        {

            MainPage = new NavigationPage(new AuthPage());
        }
    }

    protected override void OnResume()
    {
        base.OnResume();
    }


}

