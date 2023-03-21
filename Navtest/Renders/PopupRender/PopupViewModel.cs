using System;
namespace Navtest.Renders.PopupRender
{
	public class PopupViewModel : BindableObject
	{

		private string _popupTitle, _popupMessage, _continueButtonLabel, _cancelButtonLabel;
		private bool _isDismisable, _isLoading;
		public PopupViewModel()
		{
		}

        public string PopupTitle { get => _popupTitle;
			set
            {
				  _popupTitle = value;
				OnPropertyChanged();
            }
		}
        public string PopupMessage { get => _popupMessage; set  
            {
                _popupMessage = value;
                OnPropertyChanged();
            }
        }
        public string ContinueButtonLabel { get => _continueButtonLabel; set  
            {
                _continueButtonLabel = value;
                OnPropertyChanged();
            }
        }
        public string CancelButtonLabel { get => _cancelButtonLabel; set
            {
                _cancelButtonLabel = value;
                OnPropertyChanged();
            }
        }

        public bool IsDismisable { get => _isDismisable; set
            {
                _isDismisable = value;
                OnPropertyChanged();
            }
        }
        public bool IsLoading { get => _isLoading; set
            {
                _isLoading = value;
                OnPropertyChanged();
            }
        }
    }
}

