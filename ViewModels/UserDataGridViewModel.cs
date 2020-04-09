using System.Windows.Controls;
using CSharp_lab2.Tools;
using CSharp_lab2.Navigation;
using CSharp_lab2.Managers;
using CSharp_lab2.Models;

namespace CSharp_lab2.ViewModels
{
  internal class UserDataGridViewModel : BaseViewModel
  {
#region Fields

    private Person _selectedUser;

#endregion

#region Properties

        public UserDataGridViewModel()
        {

        }
    public Person SelectedUser
    {
      get { return _selectedUser; }
      set
      {
        _selectedUser = value;
        OnPropertyChanged();
      }
    }
#endregion
#region Commands
    public RelayCommand<object> _addCommand;
    public RelayCommand<object> _editCommand;
    public RelayCommand<object> _deleteCommand;
    public RelayCommand<object> AddCommand
    {
      get
      {
        return _addCommand ??(_addCommand = new RelayCommand<object>(o => {
                               NavigationManager.Instance.Navigate(
                                 ViewType.AddUser);
                             }, o => true));
      }
    }

    public RelayCommand<object> EditCommand
    {
      get
      {
        return _editCommand ??(_editCommand = new RelayCommand<object>(o => {
                                NavigationManager.Instance.Navigate(
                                  ViewType.EditUser);
                              }, o => true));
      }
    }

    public RelayCommand<object> DeleteCommand
    {
      get
      {
        return _deleteCommand ??(_deleteCommand =
                                  new RelayCommand<object>(o => {

                                                           }, o => true));
      }
    }

#endregion
  }
}
