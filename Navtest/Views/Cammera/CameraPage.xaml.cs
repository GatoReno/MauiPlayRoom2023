using Navtest.ViewModels;

namespace Navtest.Views.Cammera;

public partial class CameraPage : ContentPage
{
	IMediaPicker _MediaPicker;

    public CameraPage(CameraPageViewModel viewModel )
	{
		InitializeComponent();
		BindingContext = viewModel; 
	}
}
