 using Navtest.Views;
using Navtest.Views.Log;
using Navtest.Views.Testing;

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
       // MainPage = new AppShell();
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

