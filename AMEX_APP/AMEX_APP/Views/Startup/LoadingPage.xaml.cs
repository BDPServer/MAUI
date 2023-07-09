using AMEX_APP.ViewModels.Startup;

namespace AMEX_APP.Views.Startup;

public partial class LoadingPage : ContentPage
{
    public LoadingPage(LoadingPageViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }
}