using AMEX_APP.ViewModels;

namespace AMEX_APP;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        this.BindingContext = new AppShellViewModel();
    }
}
