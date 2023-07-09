using AMEX_CORE.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using System.Windows.Input;

namespace AMEX_APP.ViewModels.Startup
{
    public partial class LoginPageViewModel : BaseViewModel, ILoginPageViewModel
    {
        
        private string _email;
        
        private string _password;

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        #region Commands
        public ICommand LoginCommand { get; init; }

        #endregion
        public LoginPageViewModel() {
            LoginCommand= new Command(Login);
        }
        async void Login()
        {
            if (!string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Password))
            {
                var userDetails = new UserBasicInfo();
                userDetails.Email = Email;
                userDetails.FullName = "Test User Name";

                // Student Role, Teacher Role, Admin Role,
                if (Email.ToLower().Contains("student"))
                {
                    userDetails.RoleID = (int)RoleDetails.Student;
                    userDetails.RoleText = "Student Role";
                }
                else if (Email.ToLower().Contains("teacher"))
                {
                    userDetails.RoleID = (int)RoleDetails.Teacher;
                    userDetails.RoleText = "Teacher Role";
                }
                else
                {
                    userDetails.RoleID = (int)RoleDetails.Admin;
                    userDetails.RoleText = "Admin Role";
                }


                // calling api 


                if (Preferences.ContainsKey(nameof(App.UserDetails)))
                {
                    Preferences.Remove(nameof(App.UserDetails));
                }

                string userDetailStr = JsonConvert.SerializeObject(userDetails);
                Preferences.Set(nameof(App.UserDetails), userDetailStr);
                App.UserDetails = userDetails;
                await AppConstant.AddFlyoutMenusDetails();
            }


        }
        
    }
}
