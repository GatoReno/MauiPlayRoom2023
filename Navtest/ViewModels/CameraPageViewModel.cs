using System;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;

namespace Navtest.ViewModels
{
    public class CameraPageViewModel : BindableObject
    {
        IMediaPicker _MediaPicker;
        private string _imagePath;
        private Image _DisplayPhoto;

        public Image DisplayPhoto
        {
            get => _DisplayPhoto;

            set
            {
                _DisplayPhoto = value;
                OnPropertyChanged();
            }
        }
        public string ImageSourceFromCamera
        {
            get => _imagePath;

            set
            {
                _imagePath = value;
                OnPropertyChanged();
            }
        }

        public ICommand TakePhotoCommnad { get; private set; }
        public CameraPageViewModel(IMediaPicker mediaPicker)
        {
            _MediaPicker = mediaPicker;
            TakePhotoCommnad = new Command(OnTakePhotoCommnad);
            DisplayPhoto = new Image();
        }

        ~CameraPageViewModel()
        {
            DisplayPhoto = null;
        }

        private async void OnTakePhotoCommnad(object obj)
        {
			//_MediaPicker.
			if (_MediaPicker.IsCaptureSupported)
			{
				FileResult photo = await _MediaPicker.CapturePhotoAsync();
				var source = photo.FullPath;


                string localFilePath = Path.Combine(FileSystem.CacheDirectory, photo.FileName);

                using Stream sourceStream = await photo.OpenReadAsync();
                Stream stream = await photo.OpenReadAsync();
                using FileStream localFileStream = File.OpenWrite(localFilePath);

                await sourceStream.CopyToAsync(localFileStream);
                
                DisplayPhoto.Source = ImageSource.FromStream(() =>
                {
                    return stream;
                });


                
            }
        }
    }
}

