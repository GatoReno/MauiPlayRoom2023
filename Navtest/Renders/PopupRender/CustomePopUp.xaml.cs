using CommunityToolkit.Maui.Views;
namespace Navtest.Renders;

public partial class CustomePopUp : Popup  
{
    private string _okLabel;
    private bool _isDismisable;
    private string _title;
    private string _message;
    private bool _isloading;
    private Action _custombtnAction;
    public string Title { get => _title;
        set
        {
            _title = value;
            SetTitle(_title);
        }
    }
    public string Message { get => _message; set
        {
            _message = value;
            SetMessage(_message);
        } }
     
    public string OkLabel { get => _okLabel; set  
        {
            _okLabel = value;
            SetOkLabel(_okLabel);
        }
    }


    public bool Isloading{ get => _isloading; set  
    {
            _isloading = value;
            SetLoading(_isloading);
        }
    }

    public Action CustonButtonAction
    {
        get => _custombtnAction; set
        {
            _custombtnAction = value;
            CustonButtonAction -= _custombtnAction;
            CustonButtonAction += _custombtnAction;
            CustonButtonAction += OnClosePopUp;
        }
    }

    public CustomePopUp()
    {
        InitializeComponent();
        BindingContext = this;
        IsDismisable = true;
        //SetIsDismisable(true);
    }


    public bool IsDismisable { get => _isDismisable; set   
        {
            _isDismisable = value;
            SetIsDismisable(_isDismisable);
        }
    }

    public void SetButton(string text, PopUpButtonType buttonType, System.EventHandler action)
    {
        Button btn = new Button { Text = text };
        switch (buttonType)
        {
            case PopUpButtonType.Alert:
                btn.BackgroundColor = Colors.Red;
                btn.TextColor = Colors.White;
                break;
            case PopUpButtonType.Continue:
                btn.BackgroundColor = Colors.MediumPurple;
                btn.TextColor = Colors.White;
                break;
            default:
                btn.TextColor = Colors.White;
                break;
        }
        btn.Clicked += action;
 
        MainStack.Add(btn);
    }

#region privates
    private void SetOkLabel(string okLabel)
    {
        Button btn = new Button { Text = okLabel };
        MainStack.Add(btn);
    }




    private void SetIsDismisable(bool isDismisable = true)
    {
        this.CanBeDismissedByTappingOutsideOfPopup = isDismisable;

    }


    private void SetLoading(bool isloading)
    {

        Indicator.IsVisible = isloading;
        Indicator.IsRunning = isloading;
    }

    private void SetTitle(string title)
    {
        PopUpTitle.IsVisible = true; 
    }

    private void SetMessage(string message)
    {
        PopUpMessage.IsVisible = true; 
    }
    private void OnClosePopUp()
    {
        MainStack.Children.Clear();
        Close();
    }
    private void OnButtonClicked(object sender, EventArgs e)
    {
        OnClosePopUp();
    }

    protected override void OnDismissedByTappingOutsideOfPopup()
    {
        MainStack.Children.Clear();
        base.OnDismissedByTappingOutsideOfPopup();
    }
#endregion

}
