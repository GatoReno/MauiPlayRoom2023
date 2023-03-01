namespace Navtest.Views;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
        NavigationPage.SetBackButtonTitle(this, nameof(NewPage2));

    }

    async void Button_Clicked(System.Object sender, System.EventArgs e)
    {

        await Shell.Current.GoToAsync($"/{nameof(Views.NewPage1)}");
    }

    void Button_Clicked_1(System.Object sender, System.EventArgs e)
    {
    }
}
