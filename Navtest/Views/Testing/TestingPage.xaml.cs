using CommunityToolkit.Maui.Views;
using Navtest.Renders;

namespace Navtest.Views.Testing;

public partial class TestingPage : ContentPage
{
    private TestingViewModel _viewModel;
    public TestingPage(TestingViewModel viewModel)
	{
		InitializeComponent();
        viewModel.OnShowupAction += OnShowPopupAction;

        BindingContext = _viewModel= viewModel;
      

    }

    private void OnShowPopupAction(CustomePopUp obj)
    {
        this.ShowPopup(obj);
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ShowP();
    }
    public void ShowP()
	{
        //App.Current.MainPage.ShowPopup(new CustomePopUp());
    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        this.ShowPopup(new CustomePopUp());

    }

    void Button_Clicked_1(System.Object sender, System.EventArgs e)
    {
        _viewModel.ShowPopupCommand.Execute(null);
    }
}
