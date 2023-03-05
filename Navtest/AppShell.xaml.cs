using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Maui.Views;
using Navtest.Renders;
using Navtest.Views;
using Navtest.Views.Themes;

namespace Navtest;

public partial class AppShell : Shell, INotifyPropertyChanged
{
    private bool _DocsVisibilit;
    public bool DocsVisibility
    {
        get => _DocsVisibilit;
        set
        {
            _DocsVisibilit = value;
            OnPropertyChanged();
        }
    }
    public AppShell()
    {
        InitializeComponent();
        MenuItem menuItemLogout = new MenuItem()
        {
            Text = "test 1",
            StyleClass = new[] { "menuitemstyle" }
        };
        menuItemLogout.Clicked += MenuItem_Clicked_1;
        Items.Add(menuItemLogout);
        DocsVisibility = false;
        BindingContext = this;
        Routing.RegisterRoute(nameof(AuthPage), typeof(AuthPage));
        Routing.RegisterRoute(nameof(NewPage1), typeof(NewPage1));
        Routing.RegisterRoute(nameof(NewPage2), typeof(NewPage2));
        Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
        Routing.RegisterRoute(nameof(PaymentsPage), typeof(PaymentsPage));
        Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));

        Routing.RegisterRoute(nameof(ThemePage), typeof(ThemePage));
        Routing.RegisterRoute(nameof(PickerPage), typeof(PickerPage));


    }

    void MenuItem_Clicked(System.Object sender, System.EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new AuthPage());
    }

    void MenuItem_Clicked_1(System.Object sender, System.EventArgs e)
    {
        DocsVisibility = !DocsVisibility;
        var ex = (MenuItem)sender;
        
    }

    void MenuItem_Clicked_2(System.Object sender, System.EventArgs e)
    {
        this.ShowPopup(new CustomePopUp());
    }
}

