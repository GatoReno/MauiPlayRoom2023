namespace Navtest;

public partial class MainPage : ContentPage
{
 
	public MainPage()
	{
		InitializeComponent();
	}

	 

    async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		await Shell.Current.GoToAsync($"/{nameof(Views.NewPage2)}");
    }

   async void Button_Clicked_1(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync($"/{nameof(Views.NewPage1)}");
    }

    void Button_Clicked_2(System.Object sender, System.EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new Views.AuthPage());
    }
}


