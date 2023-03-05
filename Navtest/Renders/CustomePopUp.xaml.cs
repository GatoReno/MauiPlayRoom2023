using CommunityToolkit.Maui.Views;
using static System.Net.Mime.MediaTypeNames;

namespace Navtest.Renders;

public partial class CustomePopUp : Popup
{
	ICustomePopupService customePopupService;
	public CustomePopUp()
	{
		InitializeComponent();
		Button btn = new Button();
		btn.Clicked += OnButtonClicked;
		btn.Text = "Close";
		btn.BackgroundColor = Colors.Red;
 		//MainStack.Add(btn);
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
		 Close();
    }
}
