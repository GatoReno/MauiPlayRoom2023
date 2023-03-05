using System;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;

namespace Navtest.ViewModels
{
	public class CameraPageViewModel : BindableObject
	{
		IMediaPicker _MediaPicker;
		public ICommand TakePhotoCommnad { get; private set; }
        public CameraPageViewModel(IMediaPicker mediaPicker)
		{
			_MediaPicker = mediaPicker;
			TakePhotoCommnad = new Command(OnTakePhotoCommnad);

        }

        private async void OnTakePhotoCommnad(object obj)
        {
			if (_MediaPicker.IsCaptureSupported)
			{
				FileResult ph = await _MediaPicker.CapturePhotoAsync(); 
			}
        }
    }
}

