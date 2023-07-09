using AMEX_APP.ViewModels;
using AMEX_APP.ViewModels.Dashboard;
using AMEX_APP.ViewModels.Startup;
using AMEX_APP.Views.Dashboard;
using AMEX_APP.Views.Startup;
using Microsoft.Extensions.Logging;

namespace AMEX_APP;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<AppShell>();
        //Views
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<DashboardPage>();
        builder.Services.AddSingleton<LoadingPage>();


        //View Models
        builder.Services.AddSingleton<ILoginPageViewModel, LoginPageViewModel>();
        builder.Services.AddSingleton<DashboardPageViewModel>();
        builder.Services.AddSingleton<LoadingPageViewModel>();
        return builder.Build();
	}
}
