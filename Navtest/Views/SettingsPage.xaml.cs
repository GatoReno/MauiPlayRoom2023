namespace Navtest.Views;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}

    async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync($"///{nameof(MainPage)}");
    }
}
