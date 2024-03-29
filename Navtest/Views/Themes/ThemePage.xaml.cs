﻿namespace Navtest.Views.Themes;

public partial class ThemePage : ContentPage
{
	public ThemePage()
	{
		InitializeComponent();
	}

    void Switch_Toggled(System.Object sender, Microsoft.Maui.Controls.ToggledEventArgs e)
    {

		bool toggled = (bool)e.Value;
		if (toggled)
		{
			Application.Current.UserAppTheme = AppTheme.Dark;
		}
		else
		{
            Application.Current.UserAppTheme = AppTheme.Light;

        }
    }
}
