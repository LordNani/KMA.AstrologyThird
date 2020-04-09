using System.Windows.Controls;
using CSharp_lab2.Tools;
using CSharp_lab2.Managers;
using CSharp_lab2.Navigation;

namespace CSharp_lab2.ViewModels
{
    internal class EditUserViewModel : BaseViewModel
    {
        public RelayCommand<object> _cancelCommand;
        public RelayCommand<object> CancelCommand
        {
            get
            {
                return _cancelCommand ?? (_cancelCommand = new RelayCommand<object>(o => {
                    NavigationManager.Instance.Navigate(ViewType.UserDataGridView);
                }, o => true));

            }
        }
    }
}
