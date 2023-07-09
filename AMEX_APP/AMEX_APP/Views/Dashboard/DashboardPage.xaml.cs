using AMEX_APP.ViewModels.Dashboard;

namespace AMEX_APP.Views.Dashboard;

public partial class DashboardPage : ContentPage
{
    public DashboardPage(DashboardPageViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }
}