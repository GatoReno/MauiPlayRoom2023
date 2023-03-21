using System;
using Navtest.Renders;
using Microsoft.Maui.Controls;
using CommunityToolkit.Maui.Views;

namespace Navtest.Services
{
	public class PopupService : ICustomePopupService
    {
        private CustomePopUp _customePopUp;
        
        public PopupService()
		{
            _customePopUp = new CustomePopUp();

        }

        public CustomePopUp Build()
        {
            return _customePopUp;
        }

        public void CleanPopup()
        {
            if (_customePopUp != null)
            {
                _customePopUp = null;
            }
            _customePopUp = new CustomePopUp();
        }

        public void HideLoader()
        {
            _customePopUp.Close();
        }

        public CustomePopUp IsDismisable(bool isDismisable = true)
        {
            _customePopUp.IsDismisable = isDismisable;
            return _customePopUp;
        }

        public CustomePopUp IsLoading(bool isLoding = true)
        {
            _customePopUp.Isloading = isLoding;
            return _customePopUp;
        }

        public void PopupCustome(string title, string message, string okLabel, bool isloading = false, bool isDismisable = true, Action ButtonAction = null)
        {

            _customePopUp.Title = title;
            _customePopUp.Message = message;
            _customePopUp.OkLabel = okLabel;
            _customePopUp.IsDismisable = isDismisable;
            _customePopUp.Isloading = isloading;
        }

        public CustomePopUp SetMessage(string message)
        {
            _customePopUp.Message = message;
            return _customePopUp;
        }

        public CustomePopUp SetOkButton(string text, PopUpButtonType type, System.EventHandler action)
        {
            //crear botton, asignar tipo, agregar al popup
            _customePopUp.SetButton(text, type, action);
            return _customePopUp;
        }

        public CustomePopUp SetTitle(string title)
        {
            _customePopUp.Title = title;
            return _customePopUp;


        }

        public void ShowLoader(CustomePopUp customePopUp)
        {
            Shell.Current.ShowPopup(customePopUp);
        }

       

       
    }
}

