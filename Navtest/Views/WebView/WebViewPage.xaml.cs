namespace Navtest.Views.WebView;

public partial class WebViewPage : ContentPage
{
	public WebViewPage()
	{
		InitializeComponent();
	}

    async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        await Launcher.OpenAsync("https://learn.microsoft.com/dotnet/maui");

    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        
        if (null != bootstrapwebviewer)
        {
            bootstrapwebviewer = null;
        }
    }
}
