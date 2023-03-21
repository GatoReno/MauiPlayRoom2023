namespace Navtest.Renders
{
    public enum PopUpButtonType
    {
        Alert,
        Continue
    }
    public interface ICustomePopupService
    {
        void ShowLoader(CustomePopUp customePopUp);
        void HideLoader();
        void CleanPopup();
        CustomePopUp SetOkButton(string text, PopUpButtonType type, System.EventHandler action);
        CustomePopUp SetTitle(string title);
        CustomePopUp SetMessage(string message);
        CustomePopUp IsLoading(bool isLoding = true);
        CustomePopUp IsDismisable(bool isDismisable = true);
        void PopupCustome(string title, string message, string okLabel, bool isloading = false, bool isDismisable = true, Action ButtonAction = null);
        CustomePopUp Build();
    }
}