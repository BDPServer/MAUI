
using System.Windows.Input;

namespace AMEX_APP.ViewModels
{
    public interface ILoginPageViewModel: IBaseViewModel
    {
        string Email { get; set; }
        string Password { get; set; }
        ICommand LoginCommand { get; init; }
    }
}
