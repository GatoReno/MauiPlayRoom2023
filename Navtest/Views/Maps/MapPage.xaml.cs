namespace Navtest.Views.Maps;

public partial class MapPage : ContentPage
{
	public MapPage()
	{
		InitializeComponent();
	}

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        if (mymap != null)
        {
            mymap = null;
        }
    }
}
