﻿using AMEX_CORE.Models;

namespace AMEX_APP;

public partial class App : Application
{
    public static UserBasicInfo UserDetails;
    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
