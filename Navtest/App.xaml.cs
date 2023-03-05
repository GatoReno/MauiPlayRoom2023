 using Navtest.Views;
using Navtest.Views.Log;

namespace Navtest;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        MainPage = new AppShell();


    }

    protected     override void OnStart()
    {
        base.OnStart();
        var log = true;
        MainPage = new LoadingPage(new LoadingPageViewModel());
        //if (log)
        //{
        //    MainPage = new AppShell();
        //}
        //else
        //{

        //    MainPage = new NavigationPage(new AuthPage());
        //}
    }

    protected override void OnResume()
    {
        base.OnResume();
    }


}

