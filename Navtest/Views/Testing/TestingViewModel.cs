using System;
using System.Windows.Input;
using Navtest.Renders;

namespace Navtest.Views.Testing
{
	public class TestingViewModel : BindableObject
	{
		ICustomePopupService _popupService;
		public ICommand ShowPopupCommand { get; private set; }
		public Action<CustomePopUp> OnShowupAction { get; set; }
        public TestingViewModel(ICustomePopupService popupService)
		{
			this._popupService = popupService;
			 
			ShowPopupCommand = new Command(OnPopupCommand);           
        }

        private void OnPopupCommand(object obj)
        {
            ShowPopup();
        }

        public void ShowPopup()
		{
			_popupService.CleanPopup();
			_popupService.IsLoading(false);
			_popupService.IsDismisable(false);
            _popupService.SetTitle("This a test");
            _popupService.SetMessage("hi message hi message hi hi ");
			_popupService.SetOkButton("continue", PopUpButtonType.Continue, (s, fargs) =>
			{
				Console.WriteLine("From View Model D: ........... !!!!!");
				//_popupService.IsLoading(true);
    //            _popupService.SetMessage("Loading ...");
				//Task.Delay(3000).Wait();
    //            _popupService.IsLoading(false); _popupService.SetMessage("done!");

    //            Task.Delay(2000).Wait();
				_popupService.HideLoader();
            });
           var x = _popupService.Build();
			//_popupService.ShowLoader(x);
			OnShowupAction(x);


        }
	}
}

