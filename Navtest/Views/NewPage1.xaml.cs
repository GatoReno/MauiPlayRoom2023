namespace Navtest.Views;
using Navtest;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
        
    }

   async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync($"///{nameof(MainPage)}");

    }
}
