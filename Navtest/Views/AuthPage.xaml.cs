namespace Navtest.Views;

public partial class AuthPage : ContentPage
{
	public AuthPage()
	{
		InitializeComponent();
        
	}

      void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        App.Current.MainPage = new AppShell();

    }

}
