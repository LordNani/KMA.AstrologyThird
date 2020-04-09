using CSharp_lab2.Tools;
using System.Windows;
using CSharp_lab2.Navigation;
using CSharp_lab2.Managers;
using System.Windows.Controls;

namespace CSharp_lab2.ViewModels
{
    internal class MainWindowViewModel : BaseViewModel, ILoaderOwner, IContentOwner
    {
        private Visibility _loaderVisibility = Visibility.Hidden;
        private bool _isControlEnabled = true;
        private INavigatable _contentControl;
        public Visibility LoaderVisibility
        {
            get { return _loaderVisibility; }
            set
            {
                _loaderVisibility = value;
                OnPropertyChanged();
            }
        }
        public bool IsControlEnabled
        {
            get { return _isControlEnabled; }
            set
            {
                _isControlEnabled = value;
                OnPropertyChanged();
            }
        }
        public INavigatable Content
        {
            set { _contentControl = value;
                OnPropertyChanged();
            }
            get { return _contentControl; }
            
        }

        internal MainWindowViewModel()
        {
            LoaderManager.Instance.Initialize(this);
            NavigationManager.Instance.Initialize(new InitializationNavigationModel(this));
            NavigationManager.Instance.Navigate(ViewType.UserDataGridView);

        }

      
    }
}
