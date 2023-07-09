using AMEX_APP.ViewModels;
using AMEX_APP.ViewModels.Startup;

namespace AMEX_APP.Views.Startup;

public partial class LoginPage : ContentPage
{
    private ILoginPageViewModel viewModel => BindingContext as ILoginPageViewModel;
    public LoginPage(ILoginPageViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }
}