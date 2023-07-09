using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace AMEX_APP.ViewModels
{
    public partial class BaseViewModel : ObservableObject, IBaseViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        [ObservableProperty]
        private bool _isBusy;

        [ObservableProperty]
        private string _title;
    }
}
