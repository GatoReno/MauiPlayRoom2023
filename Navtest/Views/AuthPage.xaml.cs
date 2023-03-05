using Navtest.Views.Log;

namespace Navtest.Views;

public partial class AuthPage : ContentPage
{
	public AuthPage()
	{
		InitializeComponent();
        
	}

      void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        App.Current.MainPage = new LoadingPage(new LoadingPageViewModel());

    }

    void Switch_Toggled(System.Object sender, Microsoft.Maui.Controls.ToggledEventArgs e)
    {
        var isSelected = (bool)e.Value;
        if (isSelected)
        {
            Preferences.Clear("Id_User");
            Preferences.Set("Id_User","234");
        }
        else
        {
            Preferences.Clear();
        }
    }
}
