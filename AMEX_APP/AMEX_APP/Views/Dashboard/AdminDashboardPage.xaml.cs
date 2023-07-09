using CommunityToolkit.Mvvm.Messaging;

namespace AMEX_APP.Views.Dashboard;

public partial class AdminDashboardPage : ContentPage
{
    int count = 0;
    public AdminDashboardPage()
	{
		InitializeComponent();
        WeakReferenceMessenger.Default.Register<string>(this, (r, m) =>
        {
            MainThread.BeginInvokeOnMainThread(() => { lbWelcome.Text = m; });
        });
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);

            WeakReferenceMessenger.Default.Send("HI_ANDROID");

        }
		catch (Exception ex)
		{

		}
    }
}