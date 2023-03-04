using Navtest.ViewModels;

namespace Navtest.Views;

public partial class PickerPage : ContentPage
{

	public PickerPage(PickerPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
